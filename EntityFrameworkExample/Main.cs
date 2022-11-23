using EntityFrameworkExample.Core;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EntityFrameworkExample
{
    public partial class Main : Form
    {
        private IPeopleRepository _repository;
        private IEnumerable<Person> _allpeople;
        private SaveFileDialog _savedialog;
        public Main()
        {
            _repository = new PeopleRepository();
            _allpeople = new List<Person>();
            _savedialog = new SaveFileDialog
            {
                Title = "Save",
                InitialDirectory = @"C:\",
                Filter = "XML Format (*.xml)|*.xml",
                DefaultExt = ".xml"
            };

            InitializeComponent();
        }

        private void ReadPeopleNamesFromDb()
        {
            _allpeople = _repository.GetPeople();

            foreach (var p in _allpeople)
            {
                Output.Items.Add(p.FirstName);
                Output.Items.Add(p.LastName);
            }
        }

        private void ReadPeople(object sender, MouseEventArgs e)
        {
            ReadPeopleNamesFromDb();
        }

        private void SavePeople(object sender, MouseEventArgs e)
        {
            if (Output.Items.Count == 0)
            {
                MessageBox.Show("List is emty", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (_savedialog.ShowDialog() == DialogResult.OK)
            {
                var people = Output.Items.Cast<string>().ToList();
                XMLWriter.SaveFile(people, _savedialog.FileName);
            }
        }

        private void Clear(object sender, MouseEventArgs e)
        {
            Output.Items.Clear();
            _allpeople.ToList().Clear();
        }
    }
}
