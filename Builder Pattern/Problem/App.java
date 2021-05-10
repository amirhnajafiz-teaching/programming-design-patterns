public class App 
{
	public static void main(String[] args)
	{
		BankAccount account = new BankAccount(456L, "Marge", "Springfield", 100.00, 2.5);
		BankAccount anotherAccount = new BankAccount(789L, "Homer", null, 2.5, 100.00);  // Mistake!
	}
}