using System.Data;
using System.Windows.Forms;

namespace Analizador_léxico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, c , d = 0;
        DataTable tabla = new DataTable();
        public void agrega()
        {
            tabla.Rows.Add();
        }
        public void estado5(){
            d += 1;
            dataGridView1.Rows[a].Cells[2].Value = "Operador de Adición";
            dataGridView1.Rows[a].Cells[1].Value = "5";
            a++;
        }
        public void estado6(){
            d += 1;
            dataGridView1.Rows[a].Cells[1].Value = "6";
            dataGridView1.Rows[a].Cells[2].Value = "Operador de Multiplicación";
            a++;
        }
        public void estado7(){
            dataGridView1.Rows[a].Cells[1].Value = "7";
            dataGridView1.Rows[a].Cells[2].Value = "Operador Relacional";
            a++;
        }
        public void estado4()
        {
            dataGridView1.Rows[b].Cells[1].Value = "4";
            dataGridView1.Rows[b].Cells[2].Value = "Tipo";
        }
        public void estado11(){
            dataGridView1.Rows[b].Cells[1].Value= "11";
            dataGridView1.Rows[b].Cells[2].Value = "Operador de Igualdad";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            char[] textBox1 = textBox.Text.ToCharArray();
            string token= "";
            while (d < textBox1.Length){
                agrega();
                if(textBox1[d]== ' ')
                    d += 1;
                else if(textBox1[d] == '-'){
                    agrega();
                    dataGridView1.Rows[a].Cells[0].Value = "-";
                    estado5();
                    
                }else if(textBox1[d]== '+'){
                    agrega();
                    dataGridView1.Rows[a].Cells[0].Value = "+";
                    estado5();
                }
                else if(textBox1[d] == '*'){
                    agrega();
                    dataGridView1.Rows[a].Cells[0].Value = "*";
                    estado6();
                }
                else if(textBox1[d]== '/'){
                    agrega();
                    dataGridView1.Rows[a].Cells[0].Value = "/";
                    estado6();
                }
                else if(textBox1[d] == '>'){
                    agrega();
                    d += 1;
                    dataGridView1.Rows[a].Cells[0].Value = ">";
                    estado7();
                }
                else if(textBox1[d] == '<'){
                    agrega();
                    d += 1;
                    dataGridView1.Rows[a].Cells[0].Value = "<";
                    estado7();
                }
                else if(textBox1[d]== ';'){//listo yaa
                    agrega();
                    d += 1;
                    dataGridView1.Rows[a].Cells[0].Value = ";";
                    dataGridView1.Rows[a].Cells[1].Value = "12";
                    dataGridView1.Rows[a].Cells[2].Value ="Punto y Coma";
                    a++;
                }else if (textBox1[d] == '!'){//listo
                    agrega();
                    d += 1;
                    a++;
                    dataGridView1.Rows[a].Cells[0].Value ="!";
                    dataGridView1.Rows[a].Cells[1].Value = "10";
                    dataGridView1.Rows[a].Cells[2].Value = "Operador Not";
                }
                else if (textBox1[d] == ',')
                {
                    agrega();
                    d += 1;
                    dataGridView1.Rows[a].Cells[0].Value = ",";
                    dataGridView1.Rows[a].Cells[1].Value = "13";
                    dataGridView1.Rows[a].Cells[2].Value = "Coma";
                    a++;
                }
                else if (textBox1[d] == '('){//listo paréntesis
                    agrega();
                    d += 1;
                    dataGridView1.Rows[a].Cells[0].Value = "(";
                    dataGridView1.Rows[a].Cells[1].Value = "14";
                    dataGridView1.Rows[a].Cells[2].Value = "Paréntesis";
                    a++;
                }
                else if (textBox1[d] == ')'){//listo paréntesisx2
                    agrega();
                    a++;
                    d += 1;
                    dataGridView1.Rows[a].Cells[0].Value = ")";
                    dataGridView1.Rows[a].Cells[1].Value = "15";
                    dataGridView1.Rows[a].Cells[2].Value = "Paréntesis";
                }
                else if (textBox1[d] == '{'){//listo llave
                    agrega();
                    d += 1;
                    a++;
                    dataGridView1.Rows[a].Cells[0].Value = "{";
                    dataGridView1.Rows[a].Cells[1].Value = "16";
                    dataGridView1.Rows[a].Cells[2].Value = "Llave";
                    
                }
                else if (textBox1[d] == '}'){//listo llave
                    agrega();
                    d += 1;
                    a++;
                    dataGridView1.Rows[a].Cells[0].Value = "}";
                    dataGridView1.Rows[a].Cells[1].Value = "17";
                    dataGridView1.Rows[a].Cells[2].Value = "Llave";
                }
                else if (textBox1[d]== '='){//listo
                    agrega();
                    d += 1;
                    a++;
                    dataGridView1.Rows[a].Cells[0].Value = "=";
                    dataGridView1.Rows[a].Cells[1].Value = "18";
                    dataGridView1.Rows[a].Cells[2].Value = "Operador de asignación";
                }
                else if(textBox1[d] == '$') {
                    agrega();
                    d += 1;
                    dataGridView1.Rows[a].Cells[0].Value = "$";
                    dataGridView1.Rows[a].Cells[1].Value = "23";
                    dataGridView1.Rows[a].Cells[2].Value = "Símbolo Monetario";
                    a++;
                }
                else if (char.IsLetter(textBox1[d]))
                {
                    c = d;
                    token = token + textBox1[d];
                    d += 1;
                }
                if (d < textBox1.Length)
                {
                    while (char.IsLetter(textBox1[d]) || textBox1[d] == '_')
                    {
                        token = token + textBox1[d];
                        d += 1;
                        dataGridView1.Rows[a].Cells[1].Value = "0";
                        dataGridView1.Rows[a].Cells[2].Value = "Identificador de variable";
                        if (d == textBox1.Length)
                            break;
                    }
                }
                if (d < textBox1.Length)
                {

                    while (char.IsDigit(textBox1[d]) || textBox1[d] == '.') {
                        if (char.IsDigit(textBox1[d]) || textBox1[d] == '.'){
                            token = token + textBox1[d];
                            d += 1;

                            if (d == textBox1.Length)
                                break;
                        }
                    }
                }
                dataGridView1.Rows[a].Cells[0].Value =token;
                a++;
                token = "";
            }
            for(b = 0; b < dataGridView1.Rows.Count-1;b++){ 
                string resto= Convert.ToString ( dataGridView1.Rows[ b].Cells[0].Value);
              if(dataGridView1.Rows[b].Cells[0].Value != null){
                   if(dataGridView1.Rows[b].Cells[1].Value == null){
                        bool real_entero = resto.Contains(".");
                       if(real_entero == false){
                           dataGridView1.Rows[b].Cells[1].Value = "1";
                            dataGridView1.Rows[b].Cells[2].Value = "Entero";
                        }
                        else if(real_entero== true){
                            dataGridView1.Rows[b].Cells[1].Value= "2";
                            dataGridView1.Rows[b].Cells[2].Value = "Real";
                        }
                    }
                }
                if(resto == "Int" || resto == "int" || resto == "INT"){//listooOO
                    estado4();
                }
                else if(resto == "Float" || resto == "float" || resto == "FLOAT"){//LISTO
                    estado4();
                }
                else if(resto == "Void" || resto == "void" || resto == "VOID"){//LISTO
                    estado4();
                }
                else if(resto == "<="){//listo
                    dataGridView1.Rows[a].Cells[0].Value = "<=";
                    estado7();
                }
                else if(resto == ">="){//listo
                    dataGridView1.Rows[a].Cells[0].Value = ">=";
                    estado7();
                }
                else if(resto == "=="){//listo
                    dataGridView1.Rows[a].Cells[0].Value = "==";
                    estado11();
                }
                else if(resto == "!="){//listo
                    dataGridView1.Rows[a].Cells[0].Value = "!=";
                    estado11();
                }
                else if (resto == "&&"){//listoO
                    dataGridView1.Rows[a].Cells[0].Value = "&&";
                    dataGridView1.Rows[b].Cells[1].Value = "9";
                    dataGridView1.Rows[b].Cells[2].Value = "Operador AND";
                }
                else if (resto == "||"){//listoO
                    dataGridView1.Rows[a].Cells[0].Value = "||";
                    dataGridView1.Rows[b].Cells[1].Value = "8";
                    dataGridView1.Rows[b].Cells[2].Value = "Operador AND";
                }
                else if(resto == "If" || resto == "if" || resto == "IF"){//listo
                    dataGridView1.Rows[a].Cells[0].Value = "if";
                    dataGridView1.Rows[b].Cells[1].Value = "19";
                    dataGridView1.Rows[b].Cells[2].Value = "Palabra Reservada If";
                }else if(resto == "While" || resto == "while" || resto == "WHILE"){//listo
                    dataGridView1.Rows[a].Cells[0].Value = "while";
                    dataGridView1.Rows[b].Cells[1].Value = "20";
                    dataGridView1.Rows[b].Cells[2].Value = "Palabra Reservada While";
                }else if(resto == "Return" || resto == "return" || resto == "RETURN"){//listo
                    dataGridView1.Rows[a].Cells[0].Value = "return";
                    dataGridView1.Rows[b].Cells[1].Value = "21";
                    dataGridView1.Rows[b].Cells[2].Value = "Palabra Reservada Return";
                }else if(resto == "Else" || resto == "else" || resto == "ELSE"){//listo
                    dataGridView1.Rows[a].Cells[0].Value = "else";
                    dataGridView1.Rows[b].Cells[1].Value = "22";
                    dataGridView1.Rows[b].Cells[2].Value = "Palabra Reservada Else";
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e){
            dataGridView1.DataSource = tabla.DefaultView;
        }
    }
    }
