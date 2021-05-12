public class Audio extends Factory {
	public Media getProduct(String type){
		switch(type)
		{
			case "music":
				return new Music();
			case "soundtrack":
				return new Soundtrack();
			default:
				return null;
		}
	};
}