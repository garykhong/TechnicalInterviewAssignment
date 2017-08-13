namespace TechnicalInterviewAssignment
{
    public class BracketPair
    {
        public Bracket FirstBracket { get; }
        public Bracket SecondBracket { get; }

        public BracketPair(Bracket firstBracket, Bracket secondBracket)
        {
            this.FirstBracket = firstBracket;
            this.SecondBracket = secondBracket;
        }

        public override string ToString()
        {
            return FirstBracket.Value + SecondBracket.Value;
        }
    }
}