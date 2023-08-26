Console.WriteLine("Entre com o número de despesas: ");
int numberOfExpenses = GetNumberOfExpenses();

int[,] expensesCost = new int[numberOfExpenses, 2];
for (int i = 0; i < numberOfExpenses; i++)
{
    for (int j = 0; j < 2; j++)
    {
        expensesCost[i, j] = GetExpenseCostFromUser();
    }
}

int totalExpenses = 0;
for (int i = 0; i < numberOfExpenses; i++)
{
    for (int j = 0; j < 2; j++)
    {
        totalExpenses += expensesCost[i, j];
    }
}

Console.WriteLine("O total das despesas é: " + totalExpenses);

int GetNumberOfExpenses() => 5;

int GetExpenseCostFromUser() => 3;
