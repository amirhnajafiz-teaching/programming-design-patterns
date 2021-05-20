public class PersonalInfoDB {
    private String name;
    private String email;
    private Long amount;

    public void setAmount(Long amount) {
        this.amount = amount;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Long getAmount() {
        return amount;
    }

    public String getName() {
        return name;
    }

    public String getEmail() {
        return email;
    }
}
