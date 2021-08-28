package filter.java.pattern.example;
 
import java.util.ArrayList;
import java.util.List;
 
public class OrFilterOperation implements Filter {
     
    private Filter filter1;
    private Filter filter2;
 
       public OrFilterOperation(Filter filter1, Filter filter2) {
          this.filter1 = filter1;
          this.filter2 = filter2; 
       }
 
       @Override
       public List<Employee> applyFilter(List<Employee> employees) {
        
          List<Employee> orFilterResult = new ArrayList<Employee>();
           
          List<Employee> list1 = filter1.applyFilter(employees);
          List<Employee> list2 = filter2.applyFilter(employees);
           
          orFilterResult = list1;
           
          for (Employee emp : list2) {
                 if(!orFilterResult.contains(emp)){
                     orFilterResult.add(emp);
                 }
              } 
  
          return orFilterResult;
           
       }
 
}