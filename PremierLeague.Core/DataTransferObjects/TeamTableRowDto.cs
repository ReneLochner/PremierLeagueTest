namespace PremierLeague.Core.DataTransferObjects
{
    public class TeamTableRowDto
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public int Matches { get; set; }
        public int Won { get; set; }
        public int Drawn => Matches - Won - Lost;
        public int Lost { get; set; }
        public int GoalsShot { get; set; }
        public int GoalsGotten { get; set; }
        public int GoalDifference => GoalsShot - GoalsGotten;
        public int Points => Won * 3 + Drawn;
    }
}
