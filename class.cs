using System;

Class SampleClass {

	public static int number;
	public static string strin;

	//operator overloading
	SampleClass(int num, string strs){
		number = num;
		strin = strs;
	}

	SampleClass(string strs){
		strin = strs;
	}

	public void DoThisFunc(){
		System.Console.Writeline("This method function does this with {0} and {1}", number, strin);
		DoThatFunc();
	}

	private void DoThatFuc(){
		System.Console.Writeline("This method function does that with {0} and {1}", number, strin);
	}
}

Struct SampleStruct {

	public static int number;
	public static string strin;

	//operator overloading
	SampleClass(int num, string strs){
		number = num;
		strin = strs;
	}

	SampleClass(string strs){
		strin = strs;
	}

	public void DoThisFunc(){
		System.Console.Writeline("This method function does this with {0} and {1}", number, strin);
		DoThatFunc();
	}

	private void DoThatFuc(){
		System.Console.Writeline("This method function does that with {0} and {1}", number, strin);
	}

}

//class and struct differences
Class MainClass{

	public static void main_(){
	
		SampleClass Smpl = new SampleClass(3, "Some string");
		Smpl.DoThisFunc();
		SampleClass Smpl2 = new SampleClass(7, "Some string class instance two");
		System.Console.Writeline("This {0} and {2}", Smpl.number, Smpl.strin);
		//op will have the same Smpl values

		//should give err as below is private func
		Smpl.DoThatFunc();

		//use Resharper with VisualStudio for easy coding

		//struct usage
		Smpl = SampleStruct(3, "struct string");
		Smpl.DoThisFunc();
		Smpl.DoThatFunc();
		Smpl2 = SampleStruct(5, "struct two string");

		System.Console.Writeline("This {0} and {2}", Smpl.number, Smpl.strin);
		//op should have got updated with the Smpl2 values


	}
}
