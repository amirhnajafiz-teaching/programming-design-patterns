public class AccountCreationService implements BankAccountInfo {
    private int ID;
    private String name;
    private String email;
    private Long amount;

    public AccountCreationService(int ID, String name, String email, Long amount)
    {
        this.ID = ID;
        this.name = name;
        this.email = email;
        this.amount = amount;
    }

    public void createAccount()
    {
        System.out.println("Account has been created");
    }

    @Override
    public int getID() {
        return this.ID;
    }

    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public String getEmail() {
        return this.email;
    }

    @Override
    public Long getAmount() {
        return this.amount;
    }
}
