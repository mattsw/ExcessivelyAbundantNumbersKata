
public class AbundantTest {

	public static void main(String[] args){
		AbundantNumbers test = new AbundantNumbers();
		System.out.println(testAbundant(test, 12));
		System.out.println(testAbundant(test, 10));
		System.out.println(testAbundant(test, 16));
		System.out.println(testAbundant(test, 18));
		
		
	}
	
	
	public static String testAbundant(AbundantNumbers tester, int numToCheck){
		if(tester.abundantNumber(numToCheck)){
			return (numToCheck + " is an Abundant Number");
		}
		return (numToCheck + " is not an Abundant Number");
	}
}
