import java.util.ArrayList;

public class App {
    public static void main(String[] args)
    {
        ArrayList<BankAccountInfo> accountInfos = new ArrayList<>();
        accountInfos.add(new AccountCreationService(12, "Client", "something@g.com", 12L));

        LegacyBankAccount legacyBankAccount = new LegacyBankAccount(2, "User");
        PersonalInfoDB personalInfoDB = new PersonalInfoDB();
        personalInfoDB.setEmail("Myuser@g.com");
        personalInfoDB.setName("User");

        accountInfos.add(new BankAccountAdapter(legacyBankAccount, personalInfoDB));

        for(BankAccountInfo bankAccountInfo : accountInfos)
        {
            System.out.println(bankAccountInfo.getName());
        }
    }
}
