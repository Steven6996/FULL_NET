using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CalculoNotas
{
    public partial class frmcalculonotas : Form
    {
        Validation validation = new Validation();


        public static List<Alumno> listaAlumnos = new List<Alumno>();
        public static List<Alumno> listaAlumnosBorrados = new List<Alumno>();

        public frmcalculonotas()
        {
            InitializeComponent();
        }

        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            if (validateFields())
                addUser();
        }

        private bool validateFields()
        {
            errorProvider1.Clear();
            if (!validation.isNumber(txtCode, errorProvider1, "Debe ser un numero"))
            {
                return false;
            }

            if (codeExists(int.Parse(txtCode.Text)))
            {
                errorProvider1.SetError(txtCode, "El código ya existe");
                return false;
            }

            if (!validation.isText(txtName, errorProvider1, "El nombre solo puede contener letras"))
            {
                return false;
            }

            if (!validation.isEmail(txtEmail, errorProvider1, "No es un email valido"))
            {
                return false;
            }

            if (!validation.isNumber(txtNote1, errorProvider1, "Debe ser un numero"))
            {
                return false;
            }

            if (!validation.isNumber(txtNote2, errorProvider1, "Debe ser un numero"))
            {
                return false;
            }

            if (!validation.isNumber(txtNote3, errorProvider1, "Debe ser un numero"))
            {
                return false;
            }
            if (!validation.isNumber(txtNote4, errorProvider1, "Debe ser un numero"))
            {
                return false;
            }
            return true;
        }

        private bool validateFieldsOnEdit()
        {
            errorProvider1.Clear();

            if (!validation.isText(txtName, errorProvider1, "El nombre solo puede contener letras"))
            {
                return false;
            }

            if (!validation.isEmail(txtEmail, errorProvider1, "No es un email valido"))
            {
                return false;
            }

            if (!validation.isNumber(txtNote1, errorProvider1, "Debe ser un numero"))
            {
                return false;
            }

            if (!validation.isNumber(txtNote2, errorProvider1, "Debe ser un numero"))
            {
                return false;
            }

            if (!validation.isNumber(txtNote3, errorProvider1, "Debe ser un numero"))
            {
                return false;
            }
            if (!validation.isNumber(txtNote4, errorProvider1, "Debe ser un numero"))
            {
                return false;
            }
            return true;
        }

        private void addUser()
        {
            Alumno alumno = new Alumno();

            alumno.Codigo = int.Parse(txtCode.Text);
            alumno.Nombre = txtName.Text;
            alumno.Correo = txtEmail.Text;
            alumno.Nota1 = int.Parse(txtNote1.Text);
            alumno.Nota2 = int.Parse(txtNote2.Text);
            alumno.Nota3 = int.Parse(txtNote3.Text);
            alumno.Nota4 = int.Parse(txtNote4.Text);
            alumno.NotaFinal = (alumno.Nota1 + alumno.Nota2 + alumno.Nota3 + alumno.Nota4) / 4;

            if (alumno.NotaFinal >= 3.5)
                alumno.NotaConcepto = "Aprobado";
            else
                alumno.NotaConcepto = "Reprobado";


            listaAlumnos.Add(alumno);

            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = listaAlumnos;
            clearForm();
        }


        private void clearForm()
        {
            txtCode.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtNote1.Clear();
            txtNote2.Clear();
            txtNote3.Clear();
            txtNote4.Clear();
        }

        private bool codeExists(int codigo)
        {
            foreach (Alumno alumno in listaAlumnos)
            {
                if (alumno.Codigo == codigo)
                    return true;
            }
            return false;
        }

        private void tsbSaveFile_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void tsbLoadFile_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            Console.WriteLine("loadData");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Alumno>));

            if (File.Exists("listaAlumnos.xml"))
            {

                using (FileStream fileStream = File.OpenRead("listaAlumnos.xml"))
                {
                    listaAlumnos = (List<Alumno>)xmlSerializer.Deserialize(fileStream);
                    fileStream.Close();

                }
                dgvAlumnos.DataSource = null;
                dgvAlumnos.DataSource = listaAlumnos;
            }


            if (File.Exists("listaAlumnosBorrados.xml"))
            {
                using (FileStream fileStream = File.OpenRead("listaAlumnosBorrados.xml"))
                {
                    // Use stream
                    listaAlumnosBorrados = (List<Alumno>)xmlSerializer.Deserialize(fileStream);
                    fileStream.Close();
                }

            }
        }

        public void saveData()
        {
            Console.WriteLine("saveData");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Alumno>));
            using (TextWriter textWriter = new StreamWriter("listaAlumnos.xml"))
            {
                xmlSerializer.Serialize(textWriter, listaAlumnos);
            }

            using (TextWriter textWriter = new StreamWriter("listaAlumnosBorrados.xml"))
            {
                xmlSerializer.Serialize(textWriter, listaAlumnosBorrados);
            }
        }

        private void frmcalculonotas_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void frmcalculonotas_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveData();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbSearchStudent_Click(object sender, EventArgs e)
        {
            if (validation.isNumber(txtCode, errorProvider1, "Debe ser un numero"))
            {
                if (codeExists(int.Parse(txtCode.Text)))
                {
                    Alumno alumno = obtenerAlumno(int.Parse(txtCode.Text));
                    txtName.Text = alumno.Nombre;
                    txtEmail.Text = alumno.Correo;
                    txtNote1.Text = alumno.Nota1.ToString();
                    txtNote2.Text = alumno.Nota2.ToString();
                    txtNote3.Text = alumno.Nota3.ToString();
                    txtNote4.Text = alumno.Nota4.ToString();

                    tsbEditStudent.Enabled = true;
                    tsbDeleteStudent.Enabled = true;
                    txtCode.Enabled = false;

                }else
                {
                    clearForm();
                    errorProvider1.SetError(txtCode, "El codigo no existe");
                }
            }
        }

        public Alumno obtenerAlumno(int code)
        {
            foreach (Alumno alumno in listaAlumnos)
            {
                if(alumno.Codigo == code)
                {
                    return alumno;
                }
            }
            return null;
        }


        public void recuperarAlumno()
        {
            /*
            listaAlumnos.Add(alumno);
            listaAlumnosBorrados.Remove(alumno);
            */
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = listaAlumnos;
            Console.WriteLine("actualizado -_-");
            /*
            frmcalculonotas.dgvAlumnos.Refresh();
            BindingSource source = new BindingSource();
            source.DataSource = listaAlumnos;
            frmcalculonotas.dgvAlumnos.DataSource = source;*/

            // saveData();

        }

        private void tsbEditStudent_Click(object sender, EventArgs e)
        {
            if(validateFieldsOnEdit())
                guardarCambios();
        }

        private void guardarCambios()
        {
            Alumno alumno = obtenerAlumno(int.Parse(txtCode.Text));

            alumno.Codigo = int.Parse(txtCode.Text);
            alumno.Nombre = txtName.Text;
            alumno.Correo = txtEmail.Text;
            alumno.Nota1 = int.Parse(txtNote1.Text);
            alumno.Nota2 = int.Parse(txtNote2.Text);
            alumno.Nota3 = int.Parse(txtNote3.Text);
            alumno.Nota4 = int.Parse(txtNote4.Text);
            alumno.NotaFinal = (alumno.Nota1 + alumno.Nota2 + alumno.Nota3 + alumno.Nota4) / 4;

            if (alumno.NotaFinal >= 3.5)
                alumno.NotaConcepto = "Aprobado";
            else
                alumno.NotaConcepto = "Reprobado";

            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = listaAlumnos;

            tsbEditStudent.Enabled = false;
            tsbDeleteStudent.Enabled = false;
            txtCode.Enabled = true;

            clearForm();
        }

        private void tsbDeleteStudent_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("¿are you sure you want to delete this user?", "¿Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(dialogResult == DialogResult.Yes)
            {
                Alumno alumno = obtenerAlumno(int.Parse(txtCode.Text));
                listaAlumnos.Remove(alumno);
                listaAlumnosBorrados.Add(alumno);

                dgvAlumnos.DataSource = null;
                dgvAlumnos.DataSource = listaAlumnos;

                // saveData();

                tsbEditStudent.Enabled = false;
                tsbDeleteStudent.Enabled = false;
                txtCode.Enabled = true;
                clearForm();
            }


        }
        private void tsbTrash_Click(object sender, EventArgs e)
        {
            Trash trash = new Trash();
            trash.Show();
        }

        private void tsbReload_Click(object sender, EventArgs e)
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = listaAlumnos;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade acercade = new Acercade();

            acercade.Show();
        }
    }
}
