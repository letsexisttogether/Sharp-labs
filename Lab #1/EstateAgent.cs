namespace Lab9.MainClasses
{
    public class EstateAgent
    {
        public string AgentName { get; init; }
        public string AgentMobile { get; init; }

        public EstateAgent()
        {
            AgentName = string.Empty;
            AgentMobile = string.Empty;
        }
        
        public override string ToString()
        {
            return $"Ім'я: {AgentName}, Мобільний телефон: {AgentMobile}";
        }
    }
}
