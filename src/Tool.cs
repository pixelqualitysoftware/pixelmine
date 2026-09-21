public abstract class Tool {
		public readonly string name;
		public readonly byte durabMAX;
		public byte durability = durabMAX;
		public readonly byte toughness;
		public readonly Dictionary<string, byte> recipe;
		public bool broken = false;
		public Tool(string _name, byte dmax, byte _tough, uint pr, Dictionary<string, byte> _recipe) {
		 	name = _name;
		 	durabMAX = tmax;
		 	toughness = _tough
		 	price = pr
		 	recipe = _recipe
		}
		public bool loseDURAB(this.toughness, Ore target){
				if (this.toughness < target.toughness) {
						if (this.durab == 0) this.broken = true;
						else {
								this.durab--;
								return true; 
						}
			 } 
				return false;
		}

		public void swing(this, Ore target) {
				if (broken) return;
				if (loseDURAB(this.toughness, target))
		}
}