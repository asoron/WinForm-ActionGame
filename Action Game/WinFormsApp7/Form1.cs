namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Label> GXFEnemies = new List<Label>();
        List<GroupBox> Enemies = new List<GroupBox>();
        List<ProgressBar> EnemiesHBP = new List<ProgressBar>();
        List<int> EnemiesHealth = new List<int>();

        public Label selectedEnemy;

        public bool isDead = true;

        public int Damage = 20;
        public int Health = 100;
        public int speed = 5;

        public int enemySpeed = 7;

        public int Score = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if(c is GroupBox && c.Tag == "Enemy")
                {
                    Enemies.Add(c as GroupBox);
                    foreach (Control gc in c.Controls)
                    {
                        if(gc is Label)
                        {
                            GXFEnemies.Add(gc as Label);
                        }
                        if(gc is ProgressBar)
                        {
                            EnemiesHBP.Add(gc as ProgressBar);
                        }
                    }
                    EnemiesHealth.Add(100);
                    int i = this.Height / 100;
                    c.Location = new Point(this.Width + rnd.Next(50, 1000), 100*rnd.Next(1,i));


                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveUp)
            {
                if(Player.Location.Y >0)
                    move("y", -speed);
            }
            else if (moveDown)
            {
                if(Player.Location.Y <this.Height -160)
                move("y", speed);
            }

            if (moveRight)
            {
                if(Player.Location.X < this.Width-120)
                    move("x", speed);
            }
            else if (moveLeft)
            {
                if (Player.Location.X > 0) 
                    move("x", -speed);
            }
        }

        public void move(string side,int spd)
        {
            if(side == "x")
            {
                Player.Location = new Point(Player.Location.X + spd, Player.Location.Y);
            }
            if(side == "y")
            {
                Player.Location = new Point(Player.Location.X, Player.Location.Y + spd);
            }
            HPB.Location = new Point(Player.Location.X, Player.Location.Y - 30);

        }
        public bool moveUp;
        public bool moveRight;
        public bool moveDown;
        public bool moveLeft;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
                moveUp = true;
            if(e.KeyCode == Keys.Down)
                moveDown = true;
            if(e.KeyCode == Keys.Left)
                moveLeft = true;
            if(e.KeyCode == Keys.Right)
                moveRight = true;
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            if(e.KeyCode == Keys.Space && isDead)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                isDead = false;
                Score = 0;
                enemySpeed = 7;

            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                moveUp = false;
            if (e.KeyCode == Keys.Down)
                moveDown = false;
            if (e.KeyCode == Keys.Left)
                moveLeft = false;
            if (e.KeyCode == Keys.Right)
                moveRight = false;
        }
        float t = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            int i = 0;
            foreach (GroupBox gb in Enemies)
            {

                gb.Location = new Point(gb.Location.X - enemySpeed, gb.Location.Y);
                if (gb.Bounds.IntersectsWith(Player.Bounds))
                {
                    playerHealth(-2);
                }
                if(gb.Location.X < -100)
                {
                    RespawnEnemy(gb, Enemies.IndexOf(gb));
                }
                if (selectedEnemy != null && selectedEnemy == GXFEnemies[Enemies.IndexOf(gb)])
                {
                    t += 0.1f;
                    if (t > 1)
                    {
                        EnemiesHealth[i] -= Damage;
                        if (EnemiesHealth[i] <= 0)
                        {
                            RespawnEnemy(Enemies[i],i);
                            Score++;
                            enemySpeed += Score;
                        }
                        EnemiesHBP[i].Value = EnemiesHealth[i];

                        t = 0;
                    }
                }
                i++;
            }


        }
        Random rnd = new Random();
        public void RespawnEnemy(GroupBox lb,int enemyIndex)
        {
            int i = this.Height / 100;
            lb.Location = new Point(this.Width + rnd.Next(100, 450), 100 * rnd.Next(1, i));
            EnemiesHealth[enemyIndex] = 100;
            EnemiesHBP[enemyIndex].Value = 100;
        }
        public void playerHealth(int Damage)
        {
            if (Health + Damage > 100)
                Health = 100;
            else
                Health += Damage;

            if(Health <= 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                isDead = true;
                for (int i = 0; i < Enemies.Count; i++)
                {
                    int a = this.Height / 100;
                    Enemies[i].Location = new Point(this.Width + rnd.Next(100, 450), 100 * rnd.Next(1, a));
                    EnemiesHealth[i] = 100;
                    EnemiesHBP[i].Value = 100;
                    GXFEnemies[i].BackColor = Color.Red;
                }
                playerHealth(-Health + 100);
            }
            HPB.Value = Health;
        }

        

        private void label2_MouseHover(object sender, EventArgs e)
        {
            selectedEnemy = sender as Label;
            selectedEnemy.BackColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            selectedEnemy.BackColor = Color.Red;

            selectedEnemy = null;

        }
    }
}