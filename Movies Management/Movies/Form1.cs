using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SGBD_Lab01
{
    public partial class Form1 : Form
    {
        public static string server = ConfigurationManager.AppSettings.Get("server");
        public static string database = ConfigurationManager.AppSettings.Get("database");
        public static string parentTable = ConfigurationManager.AppSettings.Get("parentTable");
        public static string childTable = ConfigurationManager.AppSettings.Get("childTable");
        public static string parentPrimaryKey = ConfigurationManager.AppSettings.Get("parentPrimaryKey");

        SqlConnection sqlConnection;

        DataSet dataSet;

        SqlDataAdapter parentDataAdapter;
        SqlDataAdapter childDataAdapter;

        BindingSource parentBindingSource;
        BindingSource childBindingSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection("Data Source=" + server + ";Database=" + database + ";Integrated Security=SSPI");

            dataSet = new DataSet();

            parentBindingSource = new BindingSource();
            childBindingSource = new BindingSource();

            parentDataAdapter = new SqlDataAdapter("SELECT * FROM " + parentTable, sqlConnection);
            childDataAdapter = new SqlDataAdapter("SELECT * FROM " + childTable, sqlConnection);

            dataSet.Clear();
            parentDataAdapter.Fill(dataSet, parentTable);
            childDataAdapter.Fill(dataSet, childTable);

            parentBindingSource.DataSource = dataSet.Tables[0];
            parentTab.DataSource = parentBindingSource;

            childBindingSource.DataSource = parentBindingSource;
            childTab.DataSource = childBindingSource;

            DataColumn parentPK = dataSet.Tables[parentTable].Columns[parentPrimaryKey];
            DataColumn childFK = dataSet.Tables[childTable].Columns[parentPrimaryKey];

            DataRelation relation = new DataRelation("fk_parent_child", parentPK, childFK);
            dataSet.Relations.Add(relation);
            childBindingSource.DataMember = "fk_parent_child";

            parentTab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            childTab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            SqlCommandBuilder parentBuilder = new SqlCommandBuilder(parentDataAdapter);
            SqlCommandBuilder childBuilder = new SqlCommandBuilder(childDataAdapter);
        }


        private void ActualizeazaButton_Click(object sender, EventArgs e)
        {
            try
            {
                parentDataAdapter.Update(dataSet, parentTable);
                childDataAdapter.Update(dataSet, childTable);
                MessageBox.Show("Actualizare cu succes!");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
    }
}
