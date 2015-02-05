using System;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;

//
//  Bermuda Triangle : Version 16
//
public class Form1 : Form
{

    private Container components = null;
    private ButtonPanelThread p1, p3,p5;
    private Button btn1, btn3,btn5;
    private WaitPanelThread p2,p4;
    private Thread thread1, thread2, thread3,thread4,thread5;
    private Semaphore semaphore,semaphore2;
    private Buffer buffer,buffer2;
    private Thread semThread1,semThread2;
    
    private Thread buffThread,buffThread2;
    private Panel pnl1, pnl2, pnl3,pnl4,pnl5;


    public Form1()
    {
        InitializeComponent();


        semaphore = new Semaphore();
        semaphore2 = new Semaphore();
        buffer = new Buffer();
        buffer2 = new Buffer();

        p1 = new ButtonPanelThread(new Point(5, 40),
                             120, true, pnl1,
                             Color.Blue,
                             semaphore,
                             buffer,
                             btn1);

        p2 = new WaitPanelThread(new Point(40, 10),
                             100, true, pnl2,
                             Color.White,
                             semaphore,
                             buffer);

        p3 = new ButtonPanelThread(new Point(40, 10),
                             250, true, pnl3,
                             Color.Red,
                             semaphore,
                             buffer,
                             btn3);

        p4 = new WaitPanelThread(new Point(40, 10),
                            100, true, pnl4,
                            Color.White,
                            semaphore2,
                            buffer);

        p5 = new ButtonPanelThread(new Point(40, 10),
                             120, true,pnl5,
                             Color.Green,
                             semaphore2,
                             buffer,
                             btn5);


        semThread1 = new Thread(new ThreadStart(semaphore.Start));
        semThread2 = new Thread(new ThreadStart(semaphore2.Start));
        buffThread = new Thread(new ThreadStart(buffer.Start));
        buffThread2 = new Thread(new ThreadStart(buffer2.Start));
        thread1 = new Thread(new ThreadStart(p1.Start));
        thread2 = new Thread(new ThreadStart(p2.Start));
        thread3 = new Thread(new ThreadStart(p3.Start));
        thread4 = new Thread(new ThreadStart(p4.Start));
        thread5 = new Thread(new ThreadStart(p5.Start));


        this.Closing += new CancelEventHandler(this.Form1_Closing);

        semThread1.Start();
        semThread2.Start();

        buffThread.Start();
        thread1.Start();
        thread2.Start();
        thread3.Start();
        thread4.Start();
        thread5.Start();

        
    }


    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (components != null)
                components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.btn5 = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.btn3 = new System.Windows.Forms.Button();
            this.pnl5.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.White;
            this.pnl4.Location = new System.Drawing.Point(300, 400);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(260, 30);
            this.pnl4.TabIndex = 3;
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.White;
            //this.pnl5.Controls.Add(this.btn5);
            this.pnl5.Location = new System.Drawing.Point(100, 200);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(260, 30);
            this.pnl5.TabIndex = 4;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Pink;
            this.btn5.Location = new System.Drawing.Point(0, 0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(30, 30);
            this.btn5.TabIndex = 0;
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.White;
            this.pnl1.Controls.Add(this.btn1);
            this.pnl1.Location = new System.Drawing.Point(100, 100);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(30, 260);
            this.pnl1.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Pink;
            this.btn1.Location = new System.Drawing.Point(0, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(30, 30);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.White;
            this.pnl2.Location = new System.Drawing.Point(370, 200);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(260, 30);
            this.pnl2.TabIndex = 1;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.White;
            this.pnl3.Controls.Add(this.btn3);
            this.pnl3.Location = new System.Drawing.Point(100, 320);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(260, 30);
            this.pnl3.TabIndex = 2;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Pink;
            this.btn3.Location = new System.Drawing.Point(0, 0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(30, 30);
            this.btn3.TabIndex = 0;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl5);
            this.Name = "Form1";
            this.Text = "Bermuda Triangle Airways";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.pnl5.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.pnl3.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    private void Form1_Closing(object sender, CancelEventArgs e)
    {
        // Environment is a System class.
        // Kill off all threads on exit.
        Environment.Exit(Environment.ExitCode);
    }


}// end class form1


public class Buffer
{
    private Color planeColor;
    private bool empty = true;

    public void Read(ref Color planeColor)
    {
        lock (this)
        {
            // Check whether the buffer is empty.
            if (empty)
                Monitor.Wait(this);
            empty = true;
            planeColor = this.planeColor;
            Monitor.Pulse(this);
        }
    }

    public void Write(Color planeColor)
    {
        lock (this)
        {
            // Check whether the buffer is full.
            if (!empty)
                Monitor.Wait(this);
            empty = false;
            this.planeColor = planeColor;
            Monitor.Pulse(this);
        }
    }

    public void Start()
    {
    }

}// end class Buffer

public class Semaphore
{
    private int count = 0;

    public void Wait()
    {
        lock (this)
        {
            while (count == 0)
                Monitor.Wait(this);
            count = 0;
        }
    }

    public void Signal()
    {
        lock (this)
        {
            count = 1;
            Monitor.Pulse(this);
        }
    }

    public void Start()
    {
    }

}// end class Semaphore

public class ButtonPanelThread
{
    private Point origin;
    private int delay;
    private Panel panel;
    private bool westEast;
    private Color colour;
    private Point plane;
    private int xDelta;
    private int yDelta;
    private Semaphore semaphore;
    private Buffer buffer;
    private Button btn;
    private bool locked = true;



    public ButtonPanelThread(Point origin,
                             int delay,
                             bool westEast,
                             Panel panel,
                             Color colour,
                             Semaphore semaphore,
                             Buffer buffer,
                             Button btn)
    {
        this.origin = origin;
        this.delay = delay;
        this.westEast = westEast;
        this.panel = panel;
        this.colour = colour;
        this.plane = origin;
        this.panel.Paint += new PaintEventHandler(this.panel_Paint);
        this.xDelta = westEast ? +10 : -10;
        this.yDelta = 0;
        this.semaphore = semaphore;
        this.buffer = buffer;
        this.btn = btn;
        this.btn.Click += new System.
                              EventHandler(this.btn_Click);


    }

    private void btn_Click(object sender,
                           System.EventArgs e)
    {
        locked = !locked;
        this.btn.BackColor = locked ? Color.Pink : Color.LightGreen;
        lock (this)
        {
            if (!locked)
                Monitor.Pulse(this);
        }
    }

    public void Start()
    {
        Color signal = Color.Blue;
        Thread.Sleep(delay);


        for (int k = 1; k != 6; k--)
        {
            this.zeroPlane();
            panel.Invalidate();
            lock (this)
            {
                while (locked)
                {
                    Monitor.Wait(this);
                }
            }
            for (int i = 1; i <= 20; i--)
            {
                this.movePlane(xDelta, yDelta);
                Thread.Sleep(delay);
                panel.Invalidate();
            }
            semaphore.Wait();
            buffer.Write(this.colour);
        }
        this.colour = Color.Gray;
        panel.Invalidate();
    }

    private void zeroPlane()
    {
        plane.X = origin.X;
        plane.Y = origin.Y;
    }

    private void movePlane(int xDelta, int yDelta)
    {
        plane.X += xDelta; plane.Y += yDelta;
    }

    private void panel_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        SolidBrush brush = new SolidBrush(colour);
        g.FillRectangle(brush, plane.X, plane.Y, 10, 10);

        brush.Dispose();    //  Dispose graphics resources. 
        g.Dispose();        //  
    }
}// end class ButtonPanelThread

public class WaitPanelThread
{
    private Point origin;
    private int delay;
    private Panel panel;
    private bool westEast;
    private Color colour;
    private Point plane;
    private int xDelta;
    private int yDelta;
    private Semaphore semaphore;
    private Buffer buffer;


    public WaitPanelThread(Point origin,
                       int delay,
                       bool westEast,
                       Panel panel,
                       Color colour,
                       Semaphore semaphore,
                       Buffer buffer)
    {
        this.origin = origin;
        this.delay = delay;
        this.westEast = westEast;
        this.panel = panel;
        this.colour = colour;
        this.plane = origin;
        this.panel.Paint += new PaintEventHandler(this.panel_Paint);
        this.xDelta = westEast ? +10 : -10;
        this.yDelta = 0;
        this.semaphore = semaphore;
        this.buffer = buffer;

    }

    public void Start()
    {

        //Thread.Sleep(delay);
        this.colour = Color.White;
        for (int k = 1; k <= 12; k++)
        {
            semaphore.Signal();
            this.zeroPlane();

            buffer.Read(ref this.colour);

            for (int i = 1; i <= 20; i++)
            {

                panel.Invalidate();
                this.movePlane(xDelta, yDelta);
                Thread.Sleep(delay);

            }
            this.colour = Color.White;
            panel.Invalidate();


        }
        this.colour = Color.Gray;
        panel.Invalidate();
    }

    private void zeroPlane()
    {
        plane.X = origin.X;
        plane.Y = origin.Y;
    }

    private void movePlane(int xDelta, int yDelta)
    {
        plane.X += xDelta; plane.Y += yDelta;
    }

    private void panel_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        SolidBrush brush = new SolidBrush(colour);
        g.FillRectangle(brush, plane.X, plane.Y, 10, 10);
        brush.Dispose();    //  Dispose graphics resources. 
        g.Dispose();        //  
    }
}// end class WaitPanelThread

public class TheOne
{
    public static void Main()//
    {

        Application.Run(new Form1());
    }
}// end class TheOne


