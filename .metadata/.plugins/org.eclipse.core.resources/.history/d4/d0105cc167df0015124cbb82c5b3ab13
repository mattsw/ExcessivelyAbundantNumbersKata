import java.util.*;
public class AbundantNumbers {
	
	private ArrayList<Integer> divisors = new ArrayList<Integer>();
	
	public boolean abundantNumber(int testNum){
		int sum = 0;
		for(int x = 1; x < testNum; x++){
			if(testNum % x == 0)
				divisors.add(x);
		}
		sum = addSum(divisors);
		return sum > testNum;
	}
	
	public int addSum(ArrayList<Integer> divs){
		int sum = 0;
		for(int x : divs){
			sum+=x;
		}
		return sum;
	}
	
}
