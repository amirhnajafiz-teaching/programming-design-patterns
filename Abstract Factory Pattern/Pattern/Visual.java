public class Visual extends Factory {
	public Media getProduct(String type){
		switch(type)
		{
			case "movie":
				return new Movie();
			case "gif":
				return new Gif();
			default:
				return null;
		}
	};
}