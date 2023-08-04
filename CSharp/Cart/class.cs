using System;

public class SampleClass {

	public int number;
	public string strin;

	//operator overloading
	public SampleClass(int num, string strs){
		number = num;
		strin = strs;
	}

	SampleClass(string strs){
		strin = strs;
	}

	public void DoThisFunc(){
		System.Console.WriteLine("This method function does this with {0} and {1}", number, strin);
		DoThatFunc();
	}

	public void DoThatFunc(){
		System.Console.WriteLine("This method function does that with {0} and {1}", number, strin);
	}
}

public struct SampleStruct {

	public int number;
	public string strin;

	//operator overloading
	public SampleStruct(int num, string strs){
		number = num;
		strin = strs;
	}

/*
	public SampleStruct(string strs){
		strin = strs;
	}*/

	public void DoThisFunc(){
		System.Console.WriteLine("This method function does this with {0} and {1}", number, strin);
		DoThatFunc();
	}

	private void DoThatFunc(){
		System.Console.WriteLine("This method function does that with {0} and {1}", number, strin);
	}

}

//class and struct differences
class MainClass{

	public static void main_(){
	
		SampleClass Smpl = new SampleClass(3, "Some string");
		Smpl.DoThisFunc();
		SampleClass Smpl2 = new SampleClass(7, "Some string class instance two");
		System.Console.WriteLine("This {0} and {2}", Smpl.number, Smpl.strin);
		//op will have the same Smpl values

		//should give err as below is private func
		Smpl.DoThatFunc();

		//use Resharper with VisualStudio for easy coding

		//struct usage
		// SampleStruct.DoThisFunc();
		var smpl = new SampleStruct(3, "struct string");
		smpl.DoThisFunc();
		// smpl.DoThatFunc();
		var smpl2 = new SampleStruct(5, "struct two string");

		System.Console.WriteLine("This {0} and {2}", smpl.number, smpl.strin);
		//op should have got updated with the Smpl2 values


	}
}
