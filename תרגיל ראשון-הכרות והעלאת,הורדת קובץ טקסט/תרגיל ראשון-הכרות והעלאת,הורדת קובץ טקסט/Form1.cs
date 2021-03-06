using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace תרגיל_ראשון_הכרות_והעלאת_הורדת_קובץ_טקסט
{
    public partial class Form1 : Form
    {
        int id = 0;
        string path = @"../../Recipes.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool checkRecipe(Recipe recipe)
        {
            if (recipe.id == 0 || recipe.name == "" || recipe.category == "" || recipe.type == "")
            {
                MessageBox.Show("Error All fields must be filled!");
                return false;
            }
            return true;
        }
        private void deleteall_Click(object sender, EventArgs e)
        {
            File.Delete(path);
        }

        private Recipe createRecipe()
        {
            string type1;
            if (radioButton1.Checked)
                type1 = radioButton1.Text;
            else if (radioButton2.Checked)
                type1 = radioButton2.Text;
            else
                type1 = radioButton3.Text;

            Recipe recipe = new Recipe(int.Parse(ID.Text), name.Text, category.Text, type1);
            return recipe;
        }
        private void add_Click(object sender, EventArgs e)
        {
            Recipe recipe = createRecipe();
            if (checkRecipe(recipe))
            {
                id = int.Parse(ID.Text);
                File.AppendAllText(path, recipe.ToString() + '\n');
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string whereToDelete = ID.Text;
            string[] arr = File.ReadAllLines(path);
            string texnew = "";
            foreach (var item in arr)
            {
                if (item.Split('.')[0] != whereToDelete)
                    texnew += (item + '\n');
            }
            File.WriteAllText(path, texnew);
        }

        private void update_Click(object sender, EventArgs e)
        {
            Recipe recipe = createRecipe();
            string whereToUpdate = ID.Text;
            string[] arr = File.ReadAllLines(path);
            string texnew = "";
            if (checkRecipe(recipe))
            {
                foreach (var item in arr)
                {
                    if (item.Split('.')[0] == whereToUpdate)
                    {
                        texnew += recipe.ToString() + '\n';
                    }
                    else
                        texnew += item + '\n';
                }
                File.WriteAllText(path, texnew);
            }
         
        }

        private void show_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText(path));
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);
        }
    }
}
