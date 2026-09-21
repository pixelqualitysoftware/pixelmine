public abstract class Ore {
		string name;
		byte toughness;
		ushort hp;
		ushort[2] range;
		byte[2] dropAMOUNTS;
		ushort priceBUY;
		ushort priceSELL;
		Ore(string n, byte tough, ushort health, ushort[] depth, byte[] drops, ushort buy, ushort sell) {
				name = n;
				toughness = tough;
				hp = health;
				range[0] = depth[0];
				range[1] = depth[1];
				dropAMOUNTS[0] = drops[0];
				dropAMOUNTS[1] = drops[1];
				priceBUY = buy;
				priceSELL = sell;
		}
}