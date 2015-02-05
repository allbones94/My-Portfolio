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
public class Form2 : Form
{

    private Container components = null;
    private ButtonPanelThread blue_counter, red_counter,green_counter,ready_counter;
    private Button btn_BlueBase, btn_RedBase,btn_greenBase,btn_ready;
    private WaitPanelThread p2, p4,p6,p8;
    private Thread thread1, thread2, thread3,thread4,thread5,thread6,thread7,thread8;
    private Semaphore semaphoreS1,semaphoreS2,semaphoreS3,semaphoreSReady,semaphoreSRunway;
    private Buffer buffer_section1,buffer_section2,buffer_section3,buffer_sReady,buffer_sRunway;
    private Thread semThreadS1, semThreadS2, semThreadS3, semThreadSReady, semThreadSRunway;
    private Thread buffThreadS1, buffThreadS2, buffThreadS3, buffThreadSReady, buffThreadSRunway;
    private Panel blueBase, section1, redBase, greenBase, section2, section3, section_ready, section_runway, section_landing;


    public Form2()
    {
        InitializeComponent();


        semaphoreS1 = new Semaphore();
        semaphoreS2 = new Semaphore();
        semaphoreS3 = new Semaphore();
        semaphoreSReady = new Semaphore();
        semaphoreSRunway = new Semaphore();

        buffer_section1 = new Buffer();
        buffer_section2 = new Buffer();
        buffer_section3 = new Buffer();
        buffer_sReady = new Buffer();
        buffer_sRunway = new Buffer();

        blue_counter = new ButtonPanelThread(new Point(10, 30),
                             120, "down", blueBase,
                             Color.Blue,
                             semaphoreS1,
                             buffer_section1,
                             btn_BlueBase,9);

        p2 = new WaitPanelThread(new Point(10, 10),
                             100, "right", section1,
                             Color.White,
                             semaphoreS1,
                             buffer_section1,12,buffer_section2,semaphoreS2);
        
        
        red_counter = new ButtonPanelThread(new Point(10, 30),
                             100, "down", redBase,
                             Color.Red,
                             semaphoreS2,
                             buffer_section2,
                             btn_RedBase,9);

        p4 = new WaitPanelThread(new Point(10, 10),
                            100, "right", section2,
                            Color.White,
                            semaphoreS2,
                            buffer_section2,12,buffer_section3,semaphoreS3);

        green_counter = new ButtonPanelThread(new Point(10, 30),
                             100, "down", greenBase,
                             Color.Green,
                             semaphoreS3,
                             buffer_section3,
                             btn_greenBase,9);

        p6 = new WaitPanelThread(new Point(10, 10),
                            100, "down", section3,
                            Color.White,
                            semaphoreS3,
                            buffer_section3,12,buffer_sReady,semaphoreSReady);
       
       ready_counter = new ButtonPanelThread(new Point(100, 0),
                             120, "left",section_ready,
                             Color.Blue,
                             semaphoreSRunway,
                             buffer_sRunway,
                             btn_ready,9);
        
        p8 = new WaitPanelThread(new Point(390, 10),
                           100, "left", section_runway,
                           Color.White,
                           semaphoreSRunway,
                           buffer_sRunway,38,buffer_sRunway,semaphoreSRunway); 

        semThreadS1 = new Thread(new ThreadStart(semaphoreS1.Start));
        buffThreadS1 = new Thread(new ThreadStart(buffer_section1.Start));

        semThreadS2 = new Thread(new ThreadStart(semaphoreS2.Start));
        buffThreadS2 = new Thread(new ThreadStart(buffer_section2.Start));

        semThreadS3 = new Thread(new ThreadStart(semaphoreS3.Start));
        buffThreadS3 = new Thread(new ThreadStart(buffer_section3.Start));

        semThreadSReady = new Thread(new ThreadStart(semaphoreSReady.Start));
        buffThreadSReady = new Thread(new ThreadStart(buffer_sReady.Start));

        semThreadSRunway = new Thread(new ThreadStart(semaphoreSRunway.Start));
        buffThreadSRunway = new Thread(new ThreadStart(buffer_sRunway.Start));


        
        thread1 = new Thread(new ThreadStart(blue_counter.Start));
        thread2 = new Thread(new ThreadStart(p2.Start));
        thread3 = new Thread(new ThreadStart(red_counter.Start));
        thread4 = new Thread(new ThreadStart(p4.Start));
        thread5 = new Thread(new ThreadStart(green_counter.Start));
        thread6 = new Thread(new ThreadStart(p6.Start));
        thread7 = new Thread(new ThreadStart(ready_counter.Start));
        thread8 = new Thread(new ThreadStart(p8.Start));

        this.Closing += new CancelEventHandler(this.Form1_Closing);

        semThreadS1.Start();
        buffThreadS1.Start();
        semThreadS2.Start();
        buffThreadS2.Start();
        semThreadS3.Start();
        buffThreadS3.Start();
        semaphoreSReady.Start();
        buffThreadSReady.Start();
        semaphoreSRunway.Start();
        buffThreadSRunway.Start();
        

        thread1.Start();
        thread2.Start();
        thread3.Start();
        thread4.Start();
        thread5.Start();
        thread6.Start();
        thread7.Start();
        thread8.Start();
        
      
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
            this.blueBase = new System.Windows.Forms.Panel();
            this.btn_BlueBase = new System.Windows.Forms.Button();
            this.section1 = new System.Windows.Forms.Panel();
            this.redBase = new System.Windows.Forms.Panel();
            this.btn_RedBase = new System.Windows.Forms.Button();
            this.section2 = new System.Windows.Forms.Panel();
            this.greenBase = new System.Windows.Forms.Panel();
            this.btn_greenBase = new System.Windows.Forms.Button();
            this.section3 = new System.Windows.Forms.Panel();
            this.section_ready = new System.Windows.Forms.Panel();
            this.btn_ready = new System.Windows.Forms.Button();
            this.section_runway = new System.Windows.Forms.Panel();
            this.section_landing = new System.Windows.Forms.Panel();
            this.blueBase.SuspendLayout();
            this.redBase.SuspendLayout();
            this.greenBase.SuspendLayout();
            this.section_ready.SuspendLayout();
            this.SuspendLayout();
            // 
            // blueBase
            // 
            this.blueBase.BackColor = System.Drawing.Color.White;
            this.blueBase.Controls.Add(this.btn_BlueBase);
            this.blueBase.Location = new System.Drawing.Point(100, 50);
            this.blueBase.Name = "blueBase";
            this.blueBase.Size = new System.Drawing.Size(30, 150);
            this.blueBase.TabIndex = 0;
            // 
            // btn_BlueBase
            // 
            this.btn_BlueBase.BackColor = System.Drawing.Color.Pink;
            this.btn_BlueBase.Location = new System.Drawing.Point(0, 0);
            this.btn_BlueBase.Name = "btn_BlueBase";
            this.btn_BlueBase.Size = new System.Drawing.Size(30, 30);
            this.btn_BlueBase.TabIndex = 0;
            this.btn_BlueBase.UseVisualStyleBackColor = false;
            // 
            // section1
            // 
            this.section1.BackColor = System.Drawing.Color.White;
            this.section1.Location = new System.Drawing.Point(100, 201);
            this.section1.Name = "section1";
            this.section1.Size = new System.Drawing.Size(149, 30);
            this.section1.TabIndex = 2;
            // 
            // redBase
            // 
            this.redBase.BackColor = System.Drawing.Color.White;
            this.redBase.Controls.Add(this.btn_RedBase);
            this.redBase.Location = new System.Drawing.Point(250, 50);
            this.redBase.Name = "redBase";
            this.redBase.Size = new System.Drawing.Size(30, 150);
            this.redBase.TabIndex = 1;
            // 
            // btn_RedBase
            // 
            this.btn_RedBase.BackColor = System.Drawing.Color.Pink;
            this.btn_RedBase.Location = new System.Drawing.Point(0, 0);
            this.btn_RedBase.Name = "btn_RedBase";
            this.btn_RedBase.Size = new System.Drawing.Size(30, 30);
            this.btn_RedBase.TabIndex = 0;
            this.btn_RedBase.UseVisualStyleBackColor = false;
            // 
            // section2
            // 
            this.section2.BackColor = System.Drawing.Color.White;
            this.section2.Location = new System.Drawing.Point(250, 201);
            this.section2.Name = "section2";
            this.section2.Size = new System.Drawing.Size(149, 30);
            this.section2.TabIndex = 3;
            // 
            // greenBase
            // 
            this.greenBase.BackColor = System.Drawing.Color.White;
            this.greenBase.Controls.Add(this.btn_greenBase);
            this.greenBase.Location = new System.Drawing.Point(400, 50);
            this.greenBase.Name = "greenBase";
            this.greenBase.Size = new System.Drawing.Size(30, 150);
            this.greenBase.TabIndex = 0;
            // 
            // btn_greenBase
            // 
            this.btn_greenBase.BackColor = System.Drawing.Color.Pink;
            this.btn_greenBase.Location = new System.Drawing.Point(0, 0);
            this.btn_greenBase.Name = "btn_greenBase";
            this.btn_greenBase.Size = new System.Drawing.Size(30, 30);
            this.btn_greenBase.TabIndex = 0;
            this.btn_greenBase.UseVisualStyleBackColor = false;
            // 
            // section3
            // 
            this.section3.BackColor = System.Drawing.Color.White;
            this.section3.Location = new System.Drawing.Point(400, 201);
            this.section3.Name = "section3";
            this.section3.Size = new System.Drawing.Size(30, 149);
            this.section3.TabIndex = 4;
            // 
            // section_ready
            // 
            this.section_ready.BackColor = System.Drawing.Color.White;
            this.section_ready.Controls.Add(this.btn_ready);
            this.section_ready.Location = new System.Drawing.Point(431, 351);
            this.section_ready.Name = "section_ready";
            this.section_ready.Size = new System.Drawing.Size(149, 30);
            this.section_ready.TabIndex = 5;
            // 
            // btn_ready
            // 
            this.btn_ready.BackColor = System.Drawing.Color.Pink;
            this.btn_ready.Location = new System.Drawing.Point(120, 0);
            this.btn_ready.Name = "btn_ready";
            this.btn_ready.Size = new System.Drawing.Size(30, 30);
            this.btn_ready.TabIndex = 0;
            this.btn_ready.UseVisualStyleBackColor = false;
            // 
            // section_runway
            // 
            this.section_runway.BackColor = System.Drawing.Color.White;
            this.section_runway.Location = new System.Drawing.Point(20, 351);
            this.section_runway.Name = "section_runway";
            this.section_runway.Size = new System.Drawing.Size(410, 30);
            this.section_runway.TabIndex = 6;
            // 
            // section_landing
            // 
            this.section_landing.BackColor = System.Drawing.Color.White;
            this.section_landing.Location = new System.Drawing.Point(100, 232);
            this.section_landing.Name = "section_landing";
            this.section_landing.Size = new System.Drawing.Size(30, 118);
            this.section_landing.TabIndex = 7;
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.blueBase);
            this.Controls.Add(this.redBase);
            this.Controls.Add(this.greenBase);
            this.Controls.Add(this.section1);
            this.Controls.Add(this.section2);
            this.Controls.Add(this.section3);
            this.Controls.Add(this.section_ready);
            this.Controls.Add(this.section_runway);
            this.Controls.Add(this.section_landing);
            this.Name = "Form2";
            this.Text = "Bermuda Triangle Airways";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.blueBase.ResumeLayout(false);
            this.redBase.ResumeLayout(false);
            this.greenBase.ResumeLayout(false);
            this.section_ready.ResumeLayout(false);
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
    private string direction;
    private Color colour;
    private Point plane;
    private int xDelta;
    private int yDelta;
    private Semaphore semaphore;
    private Buffer buffer_name;
    private Button btn;
    private bool locked = true;
    private int distance;



    public ButtonPanelThread(Point origin,
                             int delay,
                             string direction,
                             Panel panel,
                             Color colour,
                             Semaphore semaphore,
                             Buffer buffer_name,
                             Button btn,
                             int distance
                             )
    {
        this.origin = origin;
        this.delay = delay;
        this.direction = direction;
        this.panel = panel;
        this.colour = colour;
        this.plane = origin;
        this.panel.Paint += new PaintEventHandler(this.panel_Paint);
        this.semaphore = semaphore;
        this.buffer_name = buffer_name;
        this.btn = btn;
        this.distance = distance;

        //checks direction
        if (this.direction == "up")
        {
            this.xDelta = 0;
            this.yDelta = -10;
        }
        else if (this.direction == "left")
        {
            this.xDelta = -10;
            this.yDelta = 0;
        }

        else if (this.direction == "down")
        {
            this.xDelta = 0;
            this.yDelta = 10;
        }

        else if (this.direction == "right")
        {
            this.xDelta = 10;
            this.yDelta = 0;
        }


        //end checking direction
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
        Color signal = Color.Red;
        Thread.Sleep(delay);


            this.zeroPlane();
            panel.Invalidate();
            lock (this)
            {
                while (locked)
                {
                    Monitor.Wait(this);
                }
            }
            for (int i = 1; i <= this.distance; i++)
            {
                this.movePlane(xDelta, yDelta);
                Thread.Sleep(delay);
                panel.Invalidate();
            }

            
            this.buffer_name.Write(this.colour);
            this.colour = Color.White;
            semaphore.Wait();
            
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
        g.FillRectangle(brush, plane.X, plane.Y+10, 10, 10);

        brush.Dispose();    //  Dispose graphics resources. 
        g.Dispose();        //  
    }
}// end class ButtonPanelThread

public class WaitPanelThread
{
    private Point origin;
    private int delay;
    private Panel panel;
    private string direction;
    private Color colour;
    private Point plane;
    private int xDelta;
    private int yDelta;
    private Semaphore semaphore;
    private Buffer buffer_name;
    private int distance;
    private Buffer next_buffer;
    private Semaphore next_semaphore;
    

    public WaitPanelThread(Point origin,
                       int delay,
                       string direction,
                       Panel panel,
                       Color colour,
                       Semaphore semaphore,
                       Buffer buffer_name,
                       int distance,
                       Buffer next_buffer,
                       Semaphore next_semaphore
                       )
    {

        this.origin = origin;
        this.delay = delay;
        this.direction = direction;
        this.panel = panel;
        this.colour = colour;
        this.plane = origin;
        this.panel.Paint += new PaintEventHandler(this.panel_Paint);
        this.semaphore = semaphore;
        this.buffer_name = buffer_name;
        this.distance = distance;
        this.next_buffer = next_buffer;
        this.next_semaphore = next_semaphore;
       

        //checks direction
        if (this.direction == "up")
        {
            this.xDelta = 0;
            this.yDelta = -10;
        }
        else if (this.direction == "left")
        {
            this.xDelta = -10;
            this.yDelta = 0;
        }

        else if (this.direction == "down")
        {
            this.xDelta = 0;
            this.yDelta = 10;
        }

        else if (this.direction == "right")
        {
            this.xDelta = 10;
            this.yDelta = 0;
        }

    }

    public void Start()
    {
        this.colour = Color.DeepPink;
        semaphore.Signal();
        
        this.buffer_name.Read(ref this.colour);

            for (int i = 1; i <= this.distance; i++)
            {
                this.movePlane(xDelta, yDelta);
                Thread.Sleep(delay);
                panel.Invalidate();
            }

           
            //allows counter to move to the next section
            
            next_buffer.Write(this.colour);
            next_semaphore.Wait();
            
            panel.Invalidate();
            
            //change this to color.white once finished
            this.colour = Color.White;
            this.plane.X = origin.X;
            this.plane.Y = origin.Y;
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

        Application.Run(new Form2());
    }
}// end class TheOne


