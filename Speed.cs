namespace snakeGame
{
    public class Speed
    {
        public int S { get; set; }
        
        public Speed(int speed)
        {
            S = speed;
        }
        public void movmentSpeed()
        {
            System.Threading.Thread.Sleep(S);
        }
    }
}