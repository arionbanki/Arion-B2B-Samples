using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace IsIT.B2B.DoPaymentTest.UIData
{
	[DataObject]
	public class CategoryCode
	{
		string _id;
		string _text;

		private CategoryCode(string id, string text)
		{
			Id = id;
			Text = text;
		}

		public string Id
		{
			get
			{
				return _id;
			}
			private set
			{
				_id = value;
			}
		}
		public string Text
		{
			get
			{
				return _text;
			}
			private set
			{
				_text = value;
			}
		}


		public static IList<CategoryCode> GetCategoryCodes()
		{
			IList<CategoryCode> categoryCodes = new List<CategoryCode>();
			categoryCodes.Add(new CategoryCode("03", "Millifært"));
			categoryCodes.Add(new CategoryCode("KM", "Afnotagjöld sjónvarps"));
			categoryCodes.Add(new CategoryCode("AI", "Barnagæsla"));
			categoryCodes.Add(new CategoryCode("AH", "Bifreiðagjöld"));
			categoryCodes.Add(new CategoryCode("KP", "Blöð/tímarit"));
			categoryCodes.Add(new CategoryCode("RK", "Brunatrygging"));
			categoryCodes.Add(new CategoryCode("68", "MasterCard"));
			categoryCodes.Add(new CategoryCode("R1", "Fasteignagjöld"));
			categoryCodes.Add(new CategoryCode("KY", "Framkvæmdasjóður"));
			categoryCodes.Add(new CategoryCode("KH", "Félagsgjöld"));
			categoryCodes.Add(new CategoryCode("K2", "Félagslíf"));
			categoryCodes.Add(new CategoryCode("U7", "Greiðsluþjónusta"));
			categoryCodes.Add(new CategoryCode("69", "Happdrætti"));
			categoryCodes.Add(new CategoryCode("K3", "Heilsurækt"));
			categoryCodes.Add(new CategoryCode("RH", "Hiti"));
			categoryCodes.Add(new CategoryCode("A6", "Húsbréf"));
			categoryCodes.Add(new CategoryCode("RL", "Húseigendatrygging"));
			categoryCodes.Add(new CategoryCode("KA", "Húsgjald"));
			categoryCodes.Add(new CategoryCode("R3", "Húsgjöld"));
			categoryCodes.Add(new CategoryCode("07", "Innheimt"));
			categoryCodes.Add(new CategoryCode("60", "Innheimtuvíxill"));
			categoryCodes.Add(new CategoryCode("04", "Laun"));
			categoryCodes.Add(new CategoryCode("KD", "Leiga"));
			categoryCodes.Add(new CategoryCode("77", "Lánasjóður íslenskra námsmanna"));
			categoryCodes.Add(new CategoryCode("66", "Lífeyrissjóður"));
			categoryCodes.Add(new CategoryCode("NA", "Lýsing"));
			categoryCodes.Add(new CategoryCode("AL", "Meðlag"));
			categoryCodes.Add(new CategoryCode("U8", "Námslán"));
			categoryCodes.Add(new CategoryCode("KF", "Opinber gjöld"));
			categoryCodes.Add(new CategoryCode("82", "Orlof"));
			categoryCodes.Add(new CategoryCode("RR", "Rafmagn"));
			categoryCodes.Add(new CategoryCode("R0", "Rafmagn og hiti"));
			categoryCodes.Add(new CategoryCode("L2", "Reglulegur sparnaður"));
			categoryCodes.Add(new CategoryCode("37", "Reikningur"));
			categoryCodes.Add(new CategoryCode("17", "Skuldabréf"));
			categoryCodes.Add(new CategoryCode("72", "Skuldabréfalán"));
			categoryCodes.Add(new CategoryCode("94", "Sparnaðarþjónusta"));
			categoryCodes.Add(new CategoryCode("18", "Stofnlán"));
			categoryCodes.Add(new CategoryCode("KE", "Sími"));
			categoryCodes.Add(new CategoryCode("R2", "Tryggingar"));
			categoryCodes.Add(new CategoryCode("75", "Útsvar"));
			categoryCodes.Add(new CategoryCode("87", "VISA"));
			categoryCodes.Add(new CategoryCode("R4", "Viðhald"));
			categoryCodes.Add(new CategoryCode("08", "Víxill"));
			categoryCodes.Add(new CategoryCode("70", "Víxill"));
			categoryCodes.Add(new CategoryCode("K1", "Ýmislegt"));
			categoryCodes.Add(new CategoryCode("KN", "Virðisaukaskattur"));

			return categoryCodes;
		}

	}
}
