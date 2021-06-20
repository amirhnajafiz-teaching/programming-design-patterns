package filter.java.pattern.example;
 
import java.util.ArrayList;
import java.util.List;
 
public class FilterJavaPatternExample {
 
    public static void main(String[] args) {
     
        List<Employee> empList = new ArrayList<Employee>();
 
        empList.add(new Employee("Dan", "Analyst","Male"));
        empList.add(new Employee("Emilie", "Analyst", "Female"));
        empList.add(new Employee("Mike", "Analyst", "Male"));
        empList.add(new Employee("Dana", "Manager", "Female"));
        empList.add(new Employee("Elthon", "Analyst", "Male"));
        empList.add(new Employee("George", "Manager", "Male"));
        empList.add(new Employee("Ely", "Clerk", "Female"));
 
        Filter male = new IsMale();
        System.out.println("The list of Males: ");
        printList(male.applyFilter(empList));
         
        Filter female = new IsFemale();
        System.out.println("\nThe list of Females: ");
        printList(female.applyFilter(empList));
         
        Filter analyst = new IsAnalyst();
        System.out.println("\nThe list of Analysts: ");
        printList(analyst.applyFilter(empList));
         
 
        Filter maleAndAnalyst = new AndFilterOperation(male, analyst);
        System.out.println("\nThe list of Males & Analysts: ");
        printList(maleAndAnalyst.applyFilter(empList));
         
        Filter maleOrAnalyst = new OrFilterOperation(male, analyst);
        System.out.println("\nThe list of Males OR Analysts: ");
        printList(maleOrAnalyst.applyFilter(empList));
         
       }
     
    public static void printList(List<Employee> empList){
            
        for (Employee emp : empList) {
            System.out.println("Employee :: Name= " + emp.getName() + ", Job= "+emp.getJob()+ ", Gender= " + emp.getGender() );
        }
    } 
 
}