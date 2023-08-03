using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly UniversityContext _context = new UniversityContext();
        public Form1()
        {
            InitializeComponent();
            _context.People.Load();
            teacherBindingSource.DataSource = _context.People.Local.OfType<Teacher>();
            studentBindingSource.DataSource = _context.People.Local.OfType<Student>();
        }
    }
}
