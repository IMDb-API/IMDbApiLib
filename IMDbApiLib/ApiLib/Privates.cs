namespace IMDbApiLib
{
    public partial class ApiLib
    {
        private string PrepareExpression(string expression)
        {
            expression = expression.Replace(" - ", " ");
            expression = expression.Replace("Mistress of Evil", ""); // Filter in some Countries!!

            return expression;
        }
    }
}
