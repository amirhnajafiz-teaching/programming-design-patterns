package filter.java.pattern.example;
 
import java.util.ArrayList;
import java.util.List;
 
public class IsAnalyst implements Filter {
     
    @Override
    public List<Employee> applyFilter(List<Employee> employees) {
         
        List<Employee> analystsList = new ArrayList<Employee>(); 
           
        for (Employee emp : employees) {
           if(emp.getJob().equalsIgnoreCase("Analyst")){
               analystsList.add(emp);
           }
        }
         
        return analystsList;
    }
}