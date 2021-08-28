package filter.java.pattern.example;
 
import java.util.ArrayList;
import java.util.List;
 
public class AndFilterOperation implements Filter {
     
    private Filter filter1;
    private Filter filter2;
 
       public AndFilterOperation(Filter filter1, Filter filter2) {
          this.filter1 = filter1;
          this.filter2 = filter2; 
       }
 
       @Override
       public List<Employee> applyFilter(List<Employee> employees) {
        
          List<Employee> andFilterResult = new ArrayList<Employee>();
           
          andFilterResult = filter1.applyFilter(filter2.applyFilter(employees));
          
          return andFilterResult;
           
       }
 
}