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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //sql db stuff

        SqlConnection conn = new SqlConnection("Data Source=pizza2017.database.windows.net;Initial Catalog=LuigiPizzaDB;Persist Security Info=True;User ID=admin123;Password=111111");
        SqlCommand command = new SqlCommand();

        //lists for each element in the layouts
        List<Button> buttons = new List<Button>();
        List<Label> labels = new List<Label>();
        List<ComboBox> comboboxes = new List<ComboBox>();

        //lists of pizzas and ingredients that are read from the txt files
        List<Pizza> pizzas = new List<Pizza>();
        List<Ingredient> AllIngredients = new List<Ingredient>();

        // list of pizzas ready to order, this will be displayed in the listbox
        List<Pizza> pizzaOrder = new List<Pizza>();
        Pizza currentPizza = new Pizza();

        float fullPrice = 0;

        public Form1()
        {
            InitializeComponent();

            //some inits
            label1.Text = "Pizza name here";
            label3.Text = "0";
            label5.Text = "0";

            LoadIngredientsFromTxt();
            LoadPizzasFromTxt();

            // the event for each pizza button 
            void PizzaClickHandler(object sender, EventArgs e)
            {
                Button btn = (Button)sender;
                label1.Text = btn.Text;

                // I reset the comboboxes
                foreach (var c in comboboxes)
                    c.SelectedIndex = 0;

                currentPizza = new Pizza();

                // I update all the comboboxes

                foreach (var p in pizzas)
                {
                    if (btn.Text.Equals(p.getName()))
                    {
                        //we clone the current pizza object
                        currentPizza.getIngredients().Clear();

                        currentPizza.setName(p.getName());
                        currentPizza.setPrice(p.getPrice());
                        currentPizza.setIngredients(p.getIngredients());

                        foreach (var ing in p.getIngredients())
                        {
                            (comboboxes.ElementAt(labels.FindIndex(auxLabel => auxLabel.Text == ing.getName())).SelectedIndex )++;
                            label5.Text = p.getPrice().ToString();
                        }
                    }
                }
            }

            // the event for each change of ingredient ( combobox change )
            void ChangeComboboxHandler(object sender, EventArgs e)
            {
                ComboBox cmbox = (ComboBox)sender;

                foreach( var c in comboboxes )
                {
                    if (c.Equals(cmbox))
                    {
                        
                        var currentIngredient = AllIngredients.ElementAt(comboboxes.FindIndex(auxCombobox => auxCombobox.Equals(cmbox)));

                        //if    list of ing in the pizza   contains the ingreident of the combobox
                        if ((currentPizza.getIngredients().Contains(currentIngredient)))
                        {
                                // if there are 2 of the same ingredient
                            if (
                                (
                                currentPizza.getIngredients().IndexOf(currentIngredient) !=
                                currentPizza.getIngredients().LastIndexOf(currentIngredient)
                                )
                               )
                            {
                                for (int i = 0; i < 2 - c.SelectedIndex; i++)
                                {
                                    currentPizza.addToPrice(-(currentIngredient.getPrice()));
                                    currentPizza.removeIngredient(currentIngredient);
                                }
                                label5.Text = currentPizza.getPrice().ToString();
                            }

                                // if there is only one instance of the ingredient
                            if (
                                (
                                currentPizza.getIngredients().IndexOf(currentIngredient) ==
                                currentPizza.getIngredients().LastIndexOf(currentIngredient)
                                )
                                &&
                                ( currentPizza.getIngredients().IndexOf(currentIngredient)>=0 )
                               )
                            {
                                if (c.SelectedIndex == 0)
                                {
                                    currentPizza.addToPrice(-currentIngredient.getPrice());
                                    currentPizza.removeIngredient(currentIngredient);
                                }
                                if (c.SelectedIndex == 2)
                                {
                                    currentPizza.addToPrice(currentIngredient.getPrice());
                                    currentPizza.addIngredient(currentIngredient);
                                }
                                label5.Text = currentPizza.getPrice().ToString();
                            }


                        }
                        else // if the ingredient is new in the pizza
                        {
                            for(int i=0;i<c.SelectedIndex;i++)
                            {
                                currentPizza.addToPrice(currentIngredient.getPrice());
                                currentPizza.addIngredient(currentIngredient);
                            }

                            label5.Text = currentPizza.getPrice().ToString();

                        }

                    }
                }

            } // change combobox handler

            void LoadIngredientsFromTxt()
            {
                // we find the path of our project
                string textFilePath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
                //add the txt path
                textFilePath += "\\ingredients.txt";


                var filestream = new System.IO.FileStream(textFilePath,
                                              System.IO.FileMode.Open,
                                              System.IO.FileAccess.Read,
                                              System.IO.FileShare.ReadWrite);
                var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);

                string lineOfText;
                string[] splits;

                // we read each ingredient and add a label and a combobox for it
                while ((lineOfText = file.ReadLine()) != null)
                {
                    splits = lineOfText.Split(' ');

                    // label stuff
                    Label label = new Label();
                    labels.Add(label);

                    label.Text = splits[0];

                    label.Margin = new Padding(5, 5, 5, 25);

                    flowLayoutPanelIngredients.Controls.Add(label);


                    //combobox stuff
                    ComboBox combobox = new ComboBox();

                    combobox.SelectionChangeCommitted += ChangeComboboxHandler;


                    combobox.Items.Add("0");
                    combobox.Items.Add("1");
                    combobox.Items.Add("2");

                    combobox.Size = new Size(45, 30);
                    combobox.Margin = new Padding(5, 5, 3, 25);

                    combobox.SelectedIndex = 0;

                    flowLayoutPanelIngredients.Controls.Add(combobox);

                    comboboxes.Add(combobox);
                    // we keep all the ingredients a list
                    AllIngredients.Add(new Ingredient(splits[0], Int32.Parse(splits[1])));

                    //we clear the array
                    Array.Clear(splits, 0, splits.Length);
                }
            }

            void LoadPizzasFromTxt()
            {
               string textFilePath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;

               textFilePath += "\\pizzas.txt";

               var filestream = new System.IO.FileStream(textFilePath,
                                              System.IO.FileMode.Open,
                                              System.IO.FileAccess.Read,
                                              System.IO.FileShare.ReadWrite);
               var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);

                string lineOfText;
                string[] splits;

                while ((lineOfText = file.ReadLine()) != null)
                {
                    splits = lineOfText.Split(' ');

                    // UI stuff

                    Button button = new Button();
                    buttons.Add(button);

                    button.Text = splits[0];
                    button.Size = new Size(150, 50);

                    button.Click += PizzaClickHandler;

                    flowLayoutPanelPizza.Controls.Add(button);


                    // objects stuff

                    // we introduce each ingredient in a list of ingredients in the pizza obj
                    Pizza pizza = new Pizza(splits[0], Int32.Parse(splits[1]));

                    foreach (var i in AllIngredients)
                    {
                        foreach (var j in splits)
                            if (i.getName().Equals(j))
                                pizza.addIngredient(i);
                    }

                    //we introduce the pizzas in a list of all pizas
                    pizzas.Add(pizza);

                    Array.Clear(splits, 0, splits.Length);
                }

            }


        } // form


        // bacause I need this list in form2
        public List<Ingredient> getAllIngredientsList()
        {
            return AllIngredients;
        }


        // LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'luigiPizzaDBDataSet.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.luigiPizzaDBDataSet.Table);
            command.Connection = conn;
        }


        //
        // Events
        //
        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            fullPrice = 0;

            if (pizzaOrder.Count == 0)
            {
                MessageBox.Show("Empty not allowed !");
            }
            else
            {
                foreach (var variable in pizzaOrder)
                {
                    conn.Open();
                    command.CommandText = "insert into [Table] values ('" + variable.getName() + "','" + variable.getPrice() + "','" + variable.ingredientsToString() + "','" + dateTimePicker1.Value.Date + "')";
                    command.ExecuteNonQuery();
                    conn.Close();

                }

                MessageBox.Show("Saved in DB");

                //currentPizza.getIngredients().Clear();
                pizzaOrder.Clear();
                listBox1.Items.Clear();
                label3.Text = "0";
            }
        }

        private void AddPizzaToOrderButton_Click(object sender, EventArgs e)
        {
                listBox1.Items.Add(currentPizza);
                //currentPizza.getIngredients().Clear();
            //    foreach(var p in pizzas)
           //     {
            //    if (p.getName().Equals(currentPizza.getName()))
            //        currentPizza.setIngredients(p.getIngredients());
            //    }


                pizzaOrder.Add(currentPizza);
                fullPrice += currentPizza.getPrice();
                label3.Text = fullPrice.ToString();
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                if( form2.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }

        private void ResetPizzaButton_Click(object sender, EventArgs e)
        {
            foreach(var c in comboboxes)
            {
                c.SelectedIndex = 0;
                label1.Text = "Pizza name here";
                label5.Text = "0";
            }
        }

        private void ResetOrderButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            fullPrice = 0;
            label3.Text = "0";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemovePizzaFromOrderButton_Click(object sender, EventArgs e)
        {
            pizzaOrder.Remove(pizzaOrder.ElementAt(listBox1.SelectedIndex));
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
 
}