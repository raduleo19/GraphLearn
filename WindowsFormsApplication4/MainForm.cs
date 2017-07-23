using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Management.Instrumentation;
using System.ComponentModel;
using System.Reflection;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApplication4
{

    public partial class Grafuri : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        //-------My Data----------//
        int EdgeNumber = 0;
        int autoNodeName = 0;
        int index = 0;
        int isWeighted = 0;
        int isOriented = 0;
        int isNetwork = 0;
        int current = 1;
        int LastProg = 1;
        public static int MaxTProgress = 0;
        int Score = 0;
        int QNumber=0;
        Intrebare[] QBackup = new Intrebare[1000];
        Bitmap[] Theory = new Bitmap[100];
        public static string User=null;        
        public static int TheoryProgress = 0;
        public static int ProblemsMaxScore = 0;
        public static string Clasa = null;
        public static int isConnectedToDB=0;        
        public static int Type = 1;
        Node[] NodesAdress = new Node[1000];
        int[] VisitedEdge = new int[1000];
        Tuple<int, int, int, int>[] Edges = new Tuple<int, int, int, int>[1000];        
        Node temporaryStart = null;
        Node temporaryFinish = null;
        Point MouseP = Point.Empty;
        //----------End My Data------//

        //--------Utils--------//       
        private int Dist(PointF a,PointF b)
        {
            return (int) ((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }
        public Point GetIntersection(PointF a, PointF b)
        {
            Point intersection1;
            Point intersection2;
            float  A, B, C;

            A = (b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y);
            B = 2 * ((b.X - a.X) * (a.X - b.X) + (b.Y - a.Y) * (a.Y - b.Y));
            C = (a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) - 27 * 27;         
            
            intersection1 = new Point((int)(a.X + ((-B + Math.Sqrt(B * B - 4 * A * C)) / (2 * A)) * (b.X - a.X)), (int)(a.Y + ((-B + Math.Sqrt(B * B - 4 * A * C)) / (2 * A)) * (b.Y - a.Y)));            
            intersection2 = new Point((int)(a.X + ((-B - Math.Sqrt(B * B - 4 * A * C)) / (2 * A)) * (b.X - a.X)), (int)(a.Y + ((-B - Math.Sqrt(B * B - 4 * A * C)) / (2 * A)) * (b.Y - a.Y)));

        
            double dist1 = Dist(intersection1, a);
            double dist2 = Dist(intersection2, b);

            if (dist1 < dist2)
                return intersection1;
            else
                return intersection2;      
        }
        private void DrawTextOnSegment(Graphics gr, Brush brush,Font font, string txt, ref int first_ch,ref PointF start_point, PointF end_point,bool text_above_segment)
        {
       
            float dx = end_point.X - start_point.X;
            float dy = end_point.Y - start_point.Y;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);
            dx /= dist;
            dy /= dist;

            // See how many characters will fit.
            int last_ch = first_ch;
            while (last_ch < txt.Length)
            {
                string test_string =
                    txt.Substring(first_ch, last_ch - first_ch + 1);
                if (gr.MeasureString(test_string, font).Width > dist)
                {
                    // This is one too many characters.
                    last_ch--;
                    break;
                }
                last_ch++;
            }
            if (last_ch < first_ch) return;
            if (last_ch >= txt.Length) last_ch = txt.Length - 1;
            string chars_that_fit =
                txt.Substring(first_ch, last_ch - first_ch + 1);

            // Rotate and translate to position the characters.
            GraphicsState state = gr.Save();
            if (text_above_segment)
            {
                gr.TranslateTransform(0,
                    -gr.MeasureString(chars_that_fit, font).Height,
                    MatrixOrder.Append);
            }
            float angle = (float)(180 * Math.Atan2(dy, dx) / Math.PI);            
            gr.RotateTransform(angle, MatrixOrder.Append);
            gr.TranslateTransform(start_point.X, start_point.Y,
                MatrixOrder.Append);

            // Draw the characters that fit.
            gr.DrawString(chars_that_fit, font, brush, 0, 0);

            // Restore the saved state.
            gr.Restore(state);

            // Update first_ch and start_point.
            first_ch = last_ch + 1;
            float text_width =
                gr.MeasureString(chars_that_fit, font).Width;
            start_point = new PointF(
                start_point.X + dx * text_width,
                start_point.Y + dy * text_width);
        }
        private void DrawTemporaryEdge_DoubleClick(object sender, System.EventArgs e)
        {
            temporaryStart =(Node)sender;

        }
        //--------End Utils--------//

        //--------DB Data Zone----------//
                
        public static MySqlConnection _con = new MySqlConnection("Server=iteachings.org;Port=3306;Database=iteachin_rica; Uid=iteachin_rica;Pwd=O2a1!BnRngr0;");      
        public static void Register(string a, string b, string c, string d, string e, int type)
        {

            _con.Open();
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(b, salt, 10000);
            byte[] hash= pbkdf2.GetBytes(20);
            byte[] hashbts = new byte[36];
            Array.Copy(salt, 0, hashbts, 0, 16);
            Array.Copy(hash, 0, hashbts, 16, 20);
            String pwd = Convert.ToBase64String(hashbts);
            MySqlCommand cmd = _con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO users (User,Password,Mail,Profesor,Clasa,TIP) VALUES('" + a + "','" + pwd + "','" + c + "','" + d + "','" + e + "','"+ type  + "');";

            cmd.ExecuteNonQuery();
            _con.Close();
            Grafuri.User = a;
            Grafuri.Clasa = e;            
            Grafuri.ProblemsMaxScore = 0;
            Grafuri.Type = type;
            Grafuri.isConnectedToDB = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _con.Open();
            label2.Show();
            DataTable dt = new DataTable();
            MySqlCommand cmd = _con.CreateCommand();
            cmd.CommandType = CommandType.Text;            
            cmd.CommandText = "select * from users where User='" + textBox6.Text +"'";
            cmd.ExecuteNonQuery();
            _con.Close();
            MySqlDataAdapter result = new MySqlDataAdapter(cmd);
            result.Fill(dt);

            if (dt.Rows.Count == 1) 
            {

                String hpass =  dt.Rows[0][2].ToString();
                byte[] hashBytes = Convert.FromBase64String(hpass);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);                
                var pbkdf2 = new Rfc2898DeriveBytes(textBox7.Text, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);
                
            

                 for (int i = 0; i < 20; i++)
                     if (hashBytes[i+ 16] != hash[i])
                     {
                         label2.Hide();
                         MessageBox.Show("Parola sau Nume gresit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         return;

                     }

                User = dt.Rows[0].Field<string>(1);
                Clasa = dt.Rows[0].Field<string>(6);
                TheoryProgress = dt.Rows[0].Field<int>(3);
                ProblemsMaxScore = dt.Rows[0].Field<int>(7);
                Type = dt.Rows[0].Field<int>(8);
                NameBox.Text = User;
                ClasBox.Text = Clasa;
                TProg.Value = TheoryProgress;
                LastProg = TheoryProgress;
                ProgresT.Text = TProg.Value.ToString() + "/" + MaxTProgress.ToString();
                label13.Text = ProblemsMaxScore.ToString();
                Scorebar.Value = ProblemsMaxScore;
                PrintTable();
                button3.Show();
                isConnectedToDB = 1;
                if (Type == 0)
                {                    
                    button16.Show();
                    button18.Show();

                }
                Register2.Hide();
                MainLogin.Hide();
            }
            else
            {
                MessageBox.Show("Parola sau Nume gresit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label2.Hide();
            } 
        }

        private void Update(int val,int val2)
        {
            if (isConnectedToDB == 0) return;
            _con.Open();            

             MySqlCommand cmd = _con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update users set ProgresTeorie='" + val.ToString()+ "' , ProgresAplicatii='" +val2.ToString()+ "' where User='" + User + "';";
                cmd.ExecuteNonQuery();

            _con.Close();
        }
       /* private void UpdateScore(int val)
        {

             _con.Open();

            MySqlCommand cmd = _con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update users set ProgresAplicatii='" + val + "' where User='" + User + "';";
            cmd.ExecuteNonQuery();

            _con.Close();
        }*/
        private async Task<DataTable> GetTable()
        {

            try
            {
               await _con.OpenAsync();
            }
            catch
            {
                return null;
            }
            DataTable dt = new DataTable();
            MySqlCommand cmd = _con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where TIP='1'";
            await cmd.ExecuteNonQueryAsync();
            MySqlDataAdapter result = new MySqlDataAdapter(cmd);
            result.Fill(dt);
            await _con.CloseAsync();
            return dt;

                   
        }
        private void GetQ()
        {
            try
            {
                _con.Open();
            }
            catch
            {
                return ;
            }



            DataTable dt = new DataTable();
            MySqlCommand cmd = _con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from intrebari";
            cmd.ExecuteNonQuery();
            _con.Close();
            MySqlDataAdapter result = new MySqlDataAdapter(cmd);
            result.Fill(dt);
           
            
            QNumber = 0;
            foreach(DataRow row in dt.Rows)
            {
                Intrebare newAns=new Intrebare();
       
                newAns.ID_Query = row["ID"].ToString();
                newAns.EN_Query = row["EN"].ToString();
                newAns.R1_Query = row["R1"].ToString();
                newAns.R2_Query = row["R2"].ToString();
                newAns.R3_Query = row["R3"].ToString();
                newAns.R4_Query = row["R4"].ToString();
                newAns.RS_Query = row["RS"].ToString();
                QBackup[++QNumber] = newAns;
                
            }
            Scorebar.MaximumValue = QNumber;

        }
        private void GetTheory()
        {


            try
            {
                _con.Open();
            }
            catch
            {
                return;
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = _con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from theory";
            cmd.ExecuteNonQuery();
            _con.Close();
            MySqlDataAdapter result = new MySqlDataAdapter(cmd);
            result.Fill(dt);
           
            MaxTProgress = 0;
            foreach(DataRow row in dt.Rows)
            {              
                
                byte[] bytes = (byte[])row["IMG"];
                using(var byteStream = new MemoryStream(bytes))
                {
                    Theory[++MaxTProgress] = new Bitmap(byteStream);
                }
            }
            TProg.MaximumValue = MaxTProgress;



        }
        private async Task PrintTable()
        {
            DataTable myDT = await GetTable();
            DataTable tempDT = new DataTable();
             tempDT = myDT.DefaultView.ToTable(true, "User", "Clasa", "Mail", "Profesor", "ProgresTeorie", "ProgresAplicatii");
            tempDT.Columns.Add(new DataColumn("TOTAL", typeof(int)));
            RankPanel.DataSource = tempDT;
            foreach(DataGridViewRow row in RankPanel.Rows)
            {
                row.Cells[RankPanel.Columns["TOTAL"].Index].Value = Convert.ToInt32(row.Cells[RankPanel.Columns["ProgresTeorie"].Index].Value) + Convert.ToInt32(row.Cells[RankPanel.Columns["ProgresAplicatii"].Index].Value);
            }
            RankPanel.Sort(RankPanel.Columns["TOTAL"], ListSortDirection.Descending);
        }
        //--------End DB Data Zone----------//

      
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            
            GetQ();
            GetTheory();
           
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            
            Update(LastProg,ProblemsMaxScore);

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i=1;i<=QNumber;i++) flowLayoutPanel1.Controls.Add(QBackup[i]);
            TProg.MaximumValue = MaxTProgress;
            TProg.Value = 1;
            ProgresT.Text = "1/" + MaxTProgress.ToString();
            Scorebar.MaximumValue = QNumber;
            Loading.Hide();

        }

        public Grafuri()
        {
         

            InitializeComponent();
            this.CenterToScreen();
            button10.Hide();
            meniu1.BringToFront();
            button3.Hide();
            button16.Hide();
            button18.Hide();
            label2.Hide();
            Ceas.Text = DateTime.Now.ToString("HH:mm:ss");
            FormBorderStyle = FormBorderStyle.None;

            AlgoList.SelectedIndex = 0;
           

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.RunWorkerAsync();

            backgroundWorker2.DoWork += backgroundWorker2_DoWork;






        }

        //-------------Mouse Move Zone-------------//
        Point mouseDownPoint = Point.Empty;
        private void Form_mouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }
        private void Form_mouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }
        private void Form_mouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint == Point.Empty) return;
            Form Form1 = this as Form;
            Form1.Location = new Point(Form1.Location.X + (e.X - mouseDownPoint.X), Form1.Location.Y + (e.Y - mouseDownPoint.Y));
        }
        //------------End Mouse Move Zone---------//

        //----------------Drawing Zone----------------//
        private void DrawEdges(object sender, PaintEventArgs e)
        {

            Pen myPen = new Pen(Color.Black, 4);
            Font df = new Font("Times New Roman", 16, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.Black);
            Brush visitedBrush = new SolidBrush(Color.Red);
            Pen visitedPen = new Pen(Color.Red, 4);

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.High;

            //--Draw Edges--//
            if (isOriented==1)
            {
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(7, 9);
                myPen.CustomEndCap = bigArrow;
            }


            PointF intersectionPoint;
            if(temporaryStart != null)
                if(temporaryFinish != null && temporaryFinish != temporaryStart)
                {
                    intersectionPoint = GetIntersection(temporaryStart.GetCenter(), temporaryFinish.GetCenter());
                    e.Graphics.DrawLine(myPen, temporaryStart.GetCenter(), intersectionPoint);
                }
                else
                    e.Graphics.DrawLine(myPen, temporaryStart.GetCenter(), MouseP);


            for(int i = 1; i <= EdgeNumber; i++)
            {

                intersectionPoint = GetIntersection(NodesAdress[Edges[i].Item1].GetCenter(), NodesAdress[Edges[i].Item2].GetCenter());
                if(VisitedEdge[i] == 0)
                    e.Graphics.DrawLine(myPen, NodesAdress[Edges[i].Item1].GetCenter(), intersectionPoint);
                else
                    e.Graphics.DrawLine(visitedPen, NodesAdress[Edges[i].Item1].GetCenter(), intersectionPoint);
                int ch1 = 0, ch2 = 0;
                PointF pf = new PointF(((NodesAdress[Edges[i].Item1].GetCenter().X + intersectionPoint.X) / 2), ((NodesAdress[Edges[i].Item1].GetCenter().Y + intersectionPoint.Y) / 2));

                if(isWeighted == 1)
                    DrawTextOnSegment(e.Graphics, Brushes.Blue, df, Edges[i].Item3.ToString(), ref ch1, ref pf, intersectionPoint, true);
                if(isNetwork == 1)
                    DrawTextOnSegment(e.Graphics, Brushes.Blue, df, Edges[i].Item3.ToString(), ref ch2, ref pf, intersectionPoint, false);


            }
        //--End Draw Edges--//
        myPen.Dispose();

        }
        //--------------End Drawing Zone--------------//

        //----------------Graph Control Zone----------------//
        private void GraphControlInterfaceInit()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox2.Checked = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            isWeighted = 0;
            isOriented = 0;
            isNetwork = 0;
            label3.Text = "<->";
            textBox5.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Text = "Capacity";
            textBox3.Text = "Start";
            textBox4.Text = "Finish";
            textBox5.Text = "Cost";
        }
        private void ClearGraphControl(object sender, EventArgs e)
        {
            GraphControlInterfaceInit();
            for(int i = 1; i <= kk; i++)
                QueuePanel.Controls.Remove(myLabels[i]);
            for (int i = 1; i <= autoNodeName; i++) panel2.Controls.Remove(NodesAdress[i]);
            autoNodeName = 0;
            EdgeNumber = 0;
            panel2.Invalidate();

        }
        private void AddNode_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Node node1 = new Node();
            node1.MouseMove += Edge_MouseMove;
            node1.DoubleClick += DrawTemporaryEdge_DoubleClick;
            
            int tmpx = random.Next(0, panel2.Width - node1.DiameterRk + node1.BorderSz - 1);
            int tmpy = random.Next(0, panel2.Height - node1.DiameterRk + node1.BorderSz - 1);
            node1.Location = new Point(tmpx, tmpy);
            node1.Indexx = ++index;
            node1.Textx = (++autoNodeName).ToString();
            node1.Click += AddEdgeOnClick;
            panel2.Controls.Add(node1);
            NodesAdress[autoNodeName] = node1;
        }
        private void RemoveNode_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            {

                int NodeIndex;

                if (Int32.TryParse(textBox2.Text, out NodeIndex))
                {
                    for (int i = 1; i <= EdgeNumber; i++)
                    {

                        if (Edges[i].Item1 == NodeIndex || Edges[i].Item2 == NodeIndex)
                        {
                            EdgeNumber--;
                            for (int j = i; j <= EdgeNumber; j++) Edges[j] = Edges[j + 1];
                            i--;
                        }

                    }

                    for (int i = 1; i <= EdgeNumber; i++)
                    {

                        int StartNode = Edges[i].Item1; if (StartNode > NodeIndex) StartNode--;
                        int FinishNode = Edges[i].Item2; if (FinishNode > NodeIndex) FinishNode--;
                        int Cost = Edges[i].Item3;
                        int Capacity = Edges[i].Item4;
                        Edges[i] = new Tuple<int, int, int, int>(StartNode, FinishNode, Cost, Capacity);
                    }

                    panel2.Controls.Remove(NodesAdress[NodeIndex]);


                    autoNodeName--;
                    for (int i = NodeIndex; i <= autoNodeName; i++) NodesAdress[i] = NodesAdress[i + 1];
                    for (int i = NodeIndex; i <= autoNodeName; i++) NodesAdress[i].Textx = i.ToString();



                    panel2.Invalidate();


                }
            }
            textBox2.Text = "Node to remove";
        }
        private void AddEdge_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                int node1,node2;
                if (Int32.TryParse(textBox3.Text, out node1) && Int32.TryParse(textBox4.Text, out node2))
                {
                    int weight = 0, capacity = 0;


                    if (isWeighted == 1)
                        Int32.TryParse(textBox5.Text, out weight);
                    else
                        weight = 0;

                    if (isNetwork == 1)
                        Int32.TryParse(textBox1.Text, out capacity);
                    else
                        capacity = 0;

                    textBox1.Text = "Capacity";
                    textBox3.Text = "Start";
                    textBox4.Text = "Finish";
                    textBox5.Text = "Cost";

                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    if (node1 > autoNodeName && node2 > autoNodeName) return;

                    Edges[++EdgeNumber] = new Tuple<int, int, int, int>(node1, node2, weight, capacity);
                    panel2.Invalidate();

                }


            }
            textBox1.Text = "Capacity";
            textBox3.Text = "Start";
            textBox4.Text = "Finish";
            textBox5.Text = "Cost";
        }
        private void RemoveEdge_Click(object sender, EventArgs e)
        {
            int Node1Index;
            int Node2Index;
            if (Int32.TryParse(textBox3.Text, out Node1Index) && Int32.TryParse(textBox4.Text, out Node2Index))
            {
                for (int i = 1; i <= EdgeNumber; i++)
                {

                    if ((Edges[i].Item1 == Node1Index && Edges[i].Item2 == Node2Index) || (isOriented == 0 && Edges[i].Item2 == Node1Index && Edges[i].Item1 == Node2Index))
                    {
                        EdgeNumber--;
                        for (int j = i; j <= EdgeNumber; j++) Edges[j] = Edges[j + 1];
                        break;
                    }

                }
                panel2.Invalidate();
            }
        }
        private void Simulate_Click(object sender, EventArgs e)
        {
            int Start;           
            #pragma warning disable 4014
            if(AlgoList.SelectedIndex == 0 && Int32.TryParse(StartingPoint.Text, out Start)) BFS(Start);
            if (AlgoList.SelectedIndex == 1 && Int32.TryParse(StartingPoint.Text, out Start)) DFS(Start);
            if (AlgoList.SelectedIndex == 4) Kruskal();
            #pragma warning restore 4014
            

        }
        private void Reset_Click(object sender, EventArgs e)
        {
            for(int i=1;i<=kk;i++) QueuePanel.Controls.Remove(myLabels[i]);
            for (int i = 1; i <= autoNodeName; i++) NodesAdress[i].setVisited(0);
            for(int i = 1; i <= EdgeNumber; i++)  VisitedEdge[i] = 0;
            panel2.Invalidate();       
        }
        //---------------End Graph Control Zone-------------//

        //----------------Get Graph Type Zone----------------//
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                isOriented = 1;
                label3.Text = "->";
            }
            else
            {
                isOriented = 0;
                label3.Text = "<->";

            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = "Cost";
            if (checkBox2.Checked)
            {
                isWeighted = 1;
                textBox5.Enabled = true;
            }
            else
            {
                isWeighted = 0;
                textBox5.Enabled = false;
            }

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Cost";
            if (checkBox3.Checked)
            {
                isNetwork = 1;
                textBox1.Enabled = true;
            }
            else
            {
                isNetwork = 0;
                textBox1.Enabled = false;
            }
        }
        //----------------End Get Graph Type Zone----------------//

        //----------------Reset Inputs Zone----------------//
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            Clear.Focus();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();

        }
        private void AlgoList_DropDownClosed(object sender, EventArgs e)
        {
            flatMini1.Focus();
            label9.Text = "";
        }
        //----------------End Reset Inputs Zone----------------//

        //----------------Algorithms Zone----------------//

                //--------Algorithm Data Declaration Zone-------//
                Dictionary<int, List<Tuple<int, int, int>>> G ;
                Label[] myLabels = new Label[1000];
                int[] Dad;
                int[] Visited;
                int kk = 0;
                int QPoz = 0;
                int Spoz = 0;
                int isPause = 0;
                //------End Algorithm Data Declaration Zone-----//

                
                //--------------------Utils---------------------//
                public void addEdge(int startNode, int endNode, int weight,int capacity)
            {
                if (!G.ContainsKey(startNode))
                {
                    G[startNode] = new List<Tuple<int, int,int>>();
                }

                G[startNode].Add(new Tuple<int, int,int>(endNode, weight,capacity));
            }
                private void GenerateGraph()
            {
                G = new Dictionary<int, List<Tuple<int, int, int>>>();
                for (int i = 1; i <= EdgeNumber; i++)
                    if (isOriented == 0)
                    {
                        addEdge(Edges[i].Item1, Edges[i].Item2, 0, 0);
                        addEdge(Edges[i].Item2, Edges[i].Item1, 0, 0);
                    }
                    else
                        addEdge(Edges[i].Item1, Edges[i].Item2, 0, 0);
            }                                
                private int Father(int node)
                {
                if (Dad[node] != node)
                {
                    Dad[node] = Father(Dad[node]);
                }

                return Dad[node];
                }
                private void Unite(int node1,int node2)
                {
                Dad[Father(node1)] = Father(node2);
                }            
                private void SortEdges()
                {
                Tuple<int, int, int, int>[] tmparray = new Tuple<int, int, int, int>[EdgeNumber];
                for (int i = 0; i < EdgeNumber; i++) tmparray[i] = Edges[i + 1];
                Array.Sort(tmparray, (a, b) => a.Item3.CompareTo(b.Item3));
                for (int i = 1; i <= EdgeNumber; i++) Edges[i] = tmparray[i - 1];
            }
                private void AddToQueueAnim(int Node)
                {
                    Label myItem = new Label();
                    myItem.AutoSize = false;
                    myItem.Size = new Size(36,36);

                    myItem.Text = Node.ToString();
                    myItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    myLabels[++kk] = myItem;
                    QueuePanel.Controls.Add(myItem);
                }

                private void AddToStackAnim(int Node)
                {
                    Label myItem = new Label();
                    myItem.AutoSize = false;
                    myItem.Size = new Size(36, 36);

                    myItem.Text = Node.ToString();
                    myItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    myLabels[++kk] = myItem;
                    QueuePanel.Controls.Add(myItem);
                }
                //------------------End Utils-------------------//

                //------------Breadth-first Search--------------//
                private async Task BFS(int StartingNode)
                        {
                                label6.Text = "Coada";
                                if(StartingNode > autoNodeName)  return;
                                Visited = new int[1000];
                                GenerateGraph();
                                Queue<int> Q = new Queue<int>(0);
                                Q.Enqueue(StartingNode);
                                Visited[StartingNode] = 1;
                                AddToQueueAnim(StartingNode);
                       



                                while (Q.Count != 0)
                                {
                            
                                    int current = Q.Dequeue();
                                    myLabels[++QPoz].BackColor=Color.Red;
                                    NodesAdress[current].setVisited(1);
                                    Visited[current] = 1;
                                    await Task.Delay(430);
                                    while(isPause==1)      await Task.Delay(1);



                                    if(G.ContainsKey(current))
                                        foreach(var next in G[current])
                                            if(Visited[next.Item1] == 0)
                                            {
                                                await Task.Delay(430);
                                                Q.Enqueue(next.Item1);
                                                AddToQueueAnim(next.Item1);
                                            }

                                    myLabels[QPoz].BackColor = Color.White;

                                }            

                        }
                //------------Breadth-first Search--------------//

                //------------Depth-first Search----------------//
                private async Task DFS(int StartingNode)
                {
                    label6.Text = "Stiva";
                    if(StartingNode > autoNodeName) return;
                    Visited = new int[1000];
                    GenerateGraph();
                    Stack<int> St = new Stack<int>(0);
                    St.Push(StartingNode);
                    Visited[StartingNode] = 1;
                    AddToStackAnim(StartingNode);
                    Spoz = 1;

                    while(St.Count != 0)
                    {
        while(isPause == 1)
            await Task.Delay(1);
        myLabels[Spoz].BackColor = Color.Red;
                        await Task.Delay(500);

                        int current = St.Pop();
                        
                        
                        

                        NodesAdress[current].setVisited(1);
                        Visited[current] = 1;

                        if(G.ContainsKey(current))
                            foreach(var next in G[current])
                                if(Visited[next.Item1] == 0)
                                   { St.Push(next.Item1);
                                    AddToStackAnim(next.Item1);
                                        Spoz++;                     
                                 }
                      QueuePanel.Controls.Remove(myLabels[Spoz]);
                      Spoz--;

                }

                }
                //------------Deepth-first Search---------------//

                //------------Kruskal's Algorithm---------------//
                private async Task Kruskal()
                {
                    Dad = new int[1000];
                    int totalCost = 0;
                    for (int i = 1; i <= autoNodeName; i++) Dad[i] = i;
                    SortEdges();
                    for (int i = 1; i <=EdgeNumber; i++)
                    {
                        while(isPause == 1)
                            await Task.Delay(1);
                        if (Father(Edges[i].Item1) != Father(Edges[i].Item2))
                        {
                            Unite(Edges[i].Item1, Edges[i].Item2);
                            totalCost += Edges[i].Item3;
                            await Task.Delay(600);                        
                            VisitedEdge[i] = 1;
                            panel2.Invalidate();

                        }
                    }
                    label9.Text = "Max Cost: " + totalCost.ToString();
                }
                //------------Kruskal's Algorithm--------------//        

                //------------Dijkstra's Algorithm-------------//
                //------------Dijkstra's Algorithm-------------//

        //----------------End Algorithms Zone----------------//

        //----------------Meniu Control Zone-------------------//
        private async void button11_Click(object sender, EventArgs e)
        {
          
            current++;

            meniu1.BackgroundImage = Theory[current];
            meniu1.BackgroundImageLayout = ImageLayout.Zoom;
            if(current > 1)
                    button10.Show();
            if(current > LastProg)
            {
                LastProg = current;
                if (backgroundWorker2.IsBusy == true)
                    Update(LastProg, ProblemsMaxScore);
                else backgroundWorker2.RunWorkerAsync();
            }

                TProg.Value = LastProg;
                ProgresT.Text = LastProg.ToString() + "/" + MaxTProgress.ToString();

                if(current == MaxTProgress )
                    {
                        button11.Hide();
                        if( LastProg!=MaxTProgress)
                            MessageBox.Show("Ai terminat teoria!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }
        private async void button10_Click(object sender, EventArgs e)
        {

            current--;
            meniu1.BackgroundImage = Theory[current];
            meniu1.BackgroundImageLayout = ImageLayout.Zoom;

            if(current < MaxTProgress)
                    button11.Show();
            if(current == 1)
                button10.Hide();
            
            
            ProgresT.Text = LastProg.ToString() + "/" + MaxTProgress.ToString();
            TProg.Value = LastProg;

        }

        private void Namebox_Click(object sender, EventArgs e)
        {
            NBox.Clear();
        }
        private void Passbox_Click(object sender, EventArgs e)
        {
            Passbox.Clear();
        }
        private void Mailbox_Click(object sender, EventArgs e)
        {
            Mailbox.Clear();
        }
        private void Classbox_Click(object sender, EventArgs e)
        {
            Classbox.Clear();
        }
        private void ProfBox_Click(object sender, EventArgs e)
        {
            ProfBox.Clear();
        }
      
        private async void button3_Click(object sender, EventArgs e)
        {
           
            ExPanel.Hide();
            Examples.Hide();
            GraphEditorPanel.Hide();
            meniu1.Hide();
            RankPanel.BringToFront();
            RankPanel.Show();            
            Sidebar.Show();
        
             
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ExPanel.Hide();
            GraphEditorPanel.Hide();
            meniu1.Hide();
            Examples.Show();
            Examples.BringToFront();
            Sidebar.Show();
        }
        private void SaveTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "C++ File|*.cpp";
            saveFileDialog1.Title = "Save an Source File";
            saveFileDialog1.FileName = AlgoSel.Text;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                     if(AlgoSel.SelectedIndex == 0) 
                    sw.WriteLine(Properties.Resources.bfs);    
                else if(AlgoSel.SelectedIndex == 1) 
                    sw.WriteLine(Properties.Resources.dfs);
                else if(AlgoSel.SelectedIndex == 2)
                    sw.WriteLine(Properties.Resources.bellman);
                else if(AlgoSel.SelectedIndex == 3)
                    sw.WriteLine(Properties.Resources.dijkstra);
                else if(AlgoSel.SelectedIndex == 4)
                    sw.WriteLine(Properties.Resources.kruskal);
                else if(AlgoSel.SelectedIndex == 5)
                    sw.WriteLine(Properties.Resources.prim);
                else if(AlgoSel.SelectedIndex == 6)
                    sw.WriteLine(Properties.Resources.kosaraju);
                else if(AlgoSel.SelectedIndex == 7)
                    sw.WriteLine(Properties.Resources.tarjan);
                else if(AlgoSel.SelectedIndex == 8)
                    sw.WriteLine(Properties.Resources.biconexe);
                else if(AlgoSel.SelectedIndex == 9)
                    sw.WriteLine(Properties.Resources.hamiltonian);
                else if(AlgoSel.SelectedIndex == 10)
                    sw.WriteLine(Properties.Resources.eulerian);
                else if(AlgoSel.SelectedIndex == 11)
                    sw.WriteLine(Properties.Resources.flux);
                else if(AlgoSel.SelectedIndex == 12)
                    sw.WriteLine(Properties.Resources.cuplaj);

                MessageBox.Show("Salvarea a avut loc cu succes","Succes",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void button17_Click(object sender, EventArgs e)
        {

            Score = 0;
            for(int i = 1; i <= QNumber; i++)
            
                { if(QBackup[i].Ck() == 1) Score++;
        QBackup[i].Dck(); }
 MessageBox.Show("Scorul tau este:"+Score.ToString(),"Score",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(Score > ProblemsMaxScore)
            { 
                ProblemsMaxScore = Score;
               

                label13.Text = Score.ToString();
                Scorebar.Value = Score;
                if (backgroundWorker2.IsBusy == true)
                    Update(LastProg, ProblemsMaxScore);
                else backgroundWorker2.RunWorkerAsync();

            }
           
           
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
           ;
            GraphEditorPanel.Hide();
            meniu1.Hide();            
            Examples.Hide();
            
            ExPanel.BringToFront();
            ExPanel.Show();
            Sidebar.Show();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            Form Modif = new Form1();          
            Modif.Show();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Form Modif = new Form2();
         
            Modif.Show();
        }
      
        private void button6_Click(object sender, EventArgs e)
        {
            ExPanel.Hide();
            Examples.Hide();
            RankPanel.Hide();
           
            meniu1.Hide();
            GraphEditorPanel.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ExPanel.Hide();
            Examples.Hide();
            RankPanel.Hide();
            GraphEditorPanel.Hide();
            Sidebar.Show();
            meniu1.BringToFront();
            meniu1.Show();
        }
        private void Edge_MouseMove(object sender, MouseEventArgs e)
        {
            temporaryFinish = (Node)sender;
            MouseP = temporaryFinish.GetCenter();
            panel2.Invalidate();
        }
        private void AddEdgeOnClick(object sender, EventArgs e)
        {
        
            if(temporaryFinish != null && temporaryStart != null && temporaryFinish != temporaryStart)
            {int weight = 0;
                int capa = 0;

            Int32.TryParse(textBox5.Text, out weight);
         Int32.TryParse(textBox1.Text, out capa);
            Edges[++EdgeNumber] = new Tuple<int, int, int, int>(temporaryStart.Indexx, temporaryFinish.Indexx, weight, capa);
            temporaryStart = null;
            temporaryFinish = null;
        checkBox1.Enabled = false;
        checkBox2.Enabled = false;
        checkBox3.Enabled = false;
        }
        MouseP = Point.Empty;
        panel2.Invalidate();
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            temporaryFinish = null;
            MouseP = new Point(e.X, e.Y);
            panel2.Invalidate();
        }
        private void Pause_Click(object sender, EventArgs e)
        {
            isPause = 1 - isPause;
        }
        private void StartingPoint_Click(object sender, EventArgs e)
        {
            StartingPoint.Clear();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Ceas.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AlgoList_SelectionChangeCommitted(object sender, EventArgs e)
        {
        if(AlgoList.SelectedIndex == 4)
        {
        StartingPoint.Hide();
        panel4.Hide();
        }
        else
        {
        StartingPoint.Show();
        panel4.Show();
        }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Register2.Hide();
            MainLogin.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Register(NBox.Text, Passbox.Text, Mailbox.Text, ProfBox.Text, Classbox.Text, 1);
            MessageBox.Show("Succes", "Registration Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            User = NBox.Text;
            Clasa = Classbox.Text;
            isConnectedToDB = 1;
            NameBox.Text = User;
            ClasBox.Text = Clasa;
            TProg.Value = TheoryProgress;
            LastProg = TheoryProgress;
            ProgresT.Text = TProg.Value.ToString() + "/" + MaxTProgress.ToString();
            label13.Text = ProblemsMaxScore.ToString();
            Scorebar.Value = ProblemsMaxScore;
            PrintTable();
            isConnectedToDB = 1;            
            button3.Show();  
            
            Register2.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainLogin.Hide();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
         
                
        }




        //----------------End Meniu Control Zone-------------------//
    }

    
}
