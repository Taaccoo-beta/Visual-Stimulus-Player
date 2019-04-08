using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_stimulus_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("winmm")]
        static extern uint timeGetTime();

        [DllImport("winmm")]
        static extern void timeBeginPeriod(int t);
        [DllImport("winmm")]
        static extern void timeEndPeriod(int t);

        [DllImport("kernel32.dll ")]
        static extern bool QueryPerformanceCounter(ref long lpPerformanceCount);

        [DllImport("kernel32")]
        static extern bool QueryPerformanceFrequency(ref long PerformanceFrequency);

        private void Form1_Load(object sender, EventArgs e)
        {
           

            sequenceFileName_1 = new List<string>();
            sequenceFilePath_1 = new List<string>();
            sequenceFileTime_1 = new List<double>();

            try
            {
                StreamReader sR = File.OpenText(Application.StartupPath + "\\FileName_1.txt");
                int length = int.Parse(sR.ReadLine());
                for (int i = 0; i != length; i++)
                {
                    string temp = sR.ReadLine();
                    this.sequenceFileName_1.Add(temp);
                    this.lbExpSequence_1.Items.Add(temp);
                }
                sR.Close();
                sR = File.OpenText(Application.StartupPath + "\\Path_1.txt");
                length = int.Parse(sR.ReadLine());
                for (int i = 0; i != length; i++)
                {
                    string temp = sR.ReadLine();
                    this.sequenceFilePath_1.Add(temp);
                }


                sR.Close();

                sR = File.OpenText(Application.StartupPath + "\\FileTime_1.txt");
                length = int.Parse(sR.ReadLine());
                for (int i = 0; i != length; i++)
                {
                    string temp = sR.ReadLine();
                    this.sequenceFileTime_1.Add(double.Parse(temp));
                }


                sR.Close();


            }
            catch
            {
                MessageBox.Show("No Path File");
            }





            pf = new PlayerFront();
            pf.Show();
            pb = new PlayerBack();
            pb.Show();

        }

        private List<string> sequenceFilePath_1;
        private List<string> sequenceFileName_1;
        private List<double> sequenceFileTime_1;

        private PlayerFront pf;
        private PlayerBack pb;
        private void btnSetSAdd_1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();



            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;

                string fileName = path.Substring(path.LastIndexOf("\\") + 1);

                lbExpSequence_1.Items.Add(fileName);
                sequenceFilePath_1.Add(path);
                sequenceFileName_1.Add(fileName);

                pf.vlcControl1.SetMedia(new FileInfo(path));
                pf.vlcControl1.Play();
                double time = 0;
                while (true)
                {
                    if (pf.vlcControl1.GetCurrentMedia().Duration.TotalSeconds > 0)
                    {
                        time = pf.vlcControl1.GetCurrentMedia().Duration.TotalSeconds;
                        break;
                    }
                }
                pf.vlcControl1.Stop();
                this.lblShowVideoTime_1.Text = time.ToString();
                sequenceFileTime_1.Add(time);
            }
        }

        private void btnSetSDelete_1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbExpSequence_1.SelectedIndex;
                lbExpSequence_1.Items.RemoveAt(index);
                sequenceFileName_1.RemoveAt(index);
                sequenceFilePath_1.RemoveAt(index);
                sequenceFileTime_1.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("No item choosed!");
            }
        }

        private void btnSetSequenceSave_1_Click(object sender, EventArgs e)
        {
            if (sequenceFilePath_1.Count == 0)
            {
                MessageBox.Show("Not item found");
            }
            else
            {

                FileStream fs1 = new FileStream(Application.StartupPath + "\\Path_1.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);

                sw.WriteLine(sequenceFilePath_1.Count);//开始写入值
                for (int i = 0; i < sequenceFilePath_1.Count; i++)
                {
                    sw.WriteLine(sequenceFilePath_1[i]);
                }

                sw.Close();
                fs1.Close();

                fs1 = new FileStream(Application.StartupPath + "\\FileName_1.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                sw = new StreamWriter(fs1);

                sw.WriteLine(sequenceFileName_1.Count);//开始写入值
                for (int i = 0; i < sequenceFileName_1.Count; i++)
                {
                    sw.WriteLine(sequenceFileName_1[i]);
                }

                sw.Close();
                fs1.Close();

                fs1 = new FileStream(Application.StartupPath + "\\FileTime_1.txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                sw = new StreamWriter(fs1);

                sw.WriteLine(sequenceFileTime_1.Count);//开始写入值
                for (int i = 0; i < sequenceFileTime_1.Count; i++)
                {
                    sw.WriteLine(sequenceFileTime_1[i]);
                }

                sw.Close();
                fs1.Close();


            }
        }

        private void lbExpSequence_1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int selectIndex = lbExpSequence_1.SelectedIndex;
                this.lblShowVideoTime_1.Text = sequenceFileTime_1[selectIndex].ToString();
            }
            catch
            {
                ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectIndex = 0;
            bool ifCircle = false ;


            int totalTime = 0 ;
            if (ifS)
            {
                totalTime = int.Parse(this.tbTime.Text);

            }
            else
            {
                totalTime = int.Parse(this.tbTime.Text) * 60;
            }


            int vedioTime = 0;
            try
            {
                selectIndex = lbExpSequence_1.SelectedIndex;
                vedioTime = (int)sequenceFileTime_1[selectIndex];
                if (totalTime > vedioTime)
                {
                    ifCircle = true;

                }
                
                this.pf.vlcControl1.SetMedia(new FileInfo(sequenceFilePath_1[selectIndex]));
                this.pf.vlcControl1.Play();

                this.pb.vlcControl1.SetMedia(new FileInfo(sequenceFilePath_1[selectIndex]));
                this.pb.vlcControl1.Play();
            }
            catch
            {

                MessageBox.Show("You should choose a item first");
            }
           
            

            uint start = timeGetTime();
            uint newStart;
            int count = 0;
            int subCount = 0;
            bool ifStop = false;

           


            while (!ifStop)
            {

                Application.DoEvents();
                newStart = timeGetTime();

                if (newStart - start >= 100)
                {
                    count++;
                    subCount++;
                    start = newStart;


                    if(ifCircle)
                    {
                        if (count < totalTime * 10)
                        {

                            if (subCount == vedioTime * 10)
                            {
                                this.pf.vlcControl1.SetMedia(new FileInfo(sequenceFilePath_1[selectIndex]));
                                this.pf.vlcControl1.Play();
                                this.pb.vlcControl1.SetMedia(new FileInfo(sequenceFilePath_1[selectIndex]));
                                this.pb.vlcControl1.Play();
                                subCount = 0;
                            }
                        }
                        else
                        {
                            ifStop = true;
                            count = 0;
                            subCount = 0;
                            this.pf.vlcControl1.Stop();
                            this.pb.vlcControl1.Stop();
                            //vedio stop

                        }
                    }

                    else
                    {
                        if (count == totalTime * 10)
                        {

                            ifStop = true;
                            count = 0;

                            //vedio stop
                            this.pf.vlcControl1.Stop();
                            this.pb.vlcControl1.Stop();
                        }

                    }

                   
                }
            }
        }


        private bool ifS = true;
        private void btnSwitchSAndM_Click(object sender, EventArgs e)
        {
            if(ifS)
            {

                ifS = false;
                this.btnSwitchSAndM.Text = "M";

            }
            else
            {
                ifS = true;
                this.btnSwitchSAndM.Text = "S";
            }
        }
    }
}
