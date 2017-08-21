﻿using IA.Events.Attributes;
using IA.SDK;
using IA.SDK.Events;
using System.Threading.Tasks;

namespace Miki.Modules
{
    [Module(Name = "reactions")]
    public class ReactionsModule
    {
        [Command(Name = "confused")]
        public async Task ConfusedAsync(EventContext e)
        {
            string[] images = new string[]
            {
                "http://i.imgur.com/RCotXAK.png",
                "http://i.imgur.com/yN5cwQq.jpg",
                "http://i.imgur.com/5TkmRWv.png",
                "http://i.imgur.com/QBFQzCQ.png",
                "http://i.imgur.com/KjSp1W4.png",
                "http://i.imgur.com/mX6D68m.jpg",
                "http://i.imgur.com/ogA5GeN.jpg",
                "http://i.imgur.com/eCHsHQZ.jpg",
                "http://i.imgur.com/r0u2dBx.jpg",
                "http://i.imgur.com/d8oMJUg.jpg",
                "http://i.imgur.com/dkV331J.jpg",
                "http://i.imgur.com/U9N4oGR.jpg",
                "http://i.imgur.com/GA0ZtvR.jpg",
                "http://i.imgur.com/NQ2e3Dq.gifv",
                "http://i.imgur.com/5HTugJ6.jpg",
                "http://i.imgur.com/MJrBLij.png",
                "http://i.imgur.com/JgjCHPd.jpg",
                "http://i.imgur.com/KIDXXHw.gifv",
                "http://i.imgur.com/Eu0Yyqq.jpg",
                "http://i.imgur.com/P5V369I.png",
                "http://i.imgur.com/DtVEGde.gifv",
                "http://i.imgur.com/xxNH850.jpg",
                "http://i.imgur.com/gytATzW.jpg",
                "http://i.imgur.com/UrDJVC0.jpg",
                "http://i.imgur.com/3GkAnYo.png",
                "http://i.imgur.com/qTXPgyI.jpg",
                "http://i.imgur.com/GmIXuso.png",
                "http://i.imgur.com/UM8XpgR.gif",
                "http://i.imgur.com/GhoKM0u.gif",
            };

            RuntimeEmbed em = new RuntimeEmbed(new Discord.EmbedBuilder());

            em.ImageUrl = images[Global.random.Next(0, images.Length)];

            await em.SendToChannel(e.Channel);
        }

        [Command(Name = "lewd")]
        public async Task LewdAsync(EventContext e)
        {
            string[] lewd = new string[]
            {
                "http://i.imgur.com/eG42EVs.png",
                "http://i.imgur.com/8shK3jh.png",
                "http://i.imgur.com/uLKC84x.jpg",
                "http://i.imgur.com/PZCwyyE.png",
                "http://i.imgur.com/KWklw30.png",
                "http://i.imgur.com/aoLsNgx.jpg",
                "http://i.imgur.com/wyJAMVt.jpg",
                "http://i.imgur.com/2Y5ZgHH.png",
                "http://i.imgur.com/OIZyqxL.jpg",
                "http://i.imgur.com/cejd1c0.gif",
                "http://i.imgur.com/Obl7JvE.png",
                "http://i.imgur.com/PFFmM1q.png",
                "http://i.imgur.com/2vopeCM.jpg",
                "http://i.imgur.com/U4Nk0e5.jpg",
                "http://i.imgur.com/Llf61b1.jpg",
                "http://i.imgur.com/3vYPbuO.jpg",
                "http://i.imgur.com/p1twVD4.png",
                "http://i.imgur.com/kRaopT0.gif",
                "http://i.imgur.com/On8Axls.gif",
                "http://i.imgur.com/yCqJlFc.gif"
            };

            await Utils.Embed
                .SetImageUrl(lewd[Global.random.Next(0, lewd.Length)])
                .SendToChannel(e.Channel.Id);
        }

        [Command(Name = "pout")]
        public async Task PoutAsync(EventContext e)
        {
            string[] images = new string[]
            {
                "http://i.imgur.com/hsjBcz1.jpg",
                "http://i.imgur.com/oJSVNzT.jpg",
                "http://i.imgur.com/gWtmHoN.jpg",
                "http://i.imgur.com/VFG9zKV.png",
                "http://i.imgur.com/BUBiL0f.jpg",
                "http://i.imgur.com/UdlZ69E.gif",
                "http://i.imgur.com/yhryAf9.png",
                "http://i.imgur.com/d9DG2sJ.png",
                "http://i.imgur.com/uTB2HIY.png",
                "http://i.imgur.com/dVtR9vI.png",
                "http://i.imgur.com/rt7Vgn3.jpg",
                "http://i.imgur.com/uTB2HIY.png"
            };

            RuntimeEmbed em = new RuntimeEmbed(new Discord.EmbedBuilder());

            em.ImageUrl = images[Global.random.Next(0, images.Length)];

            await em.SendToChannel(e.Channel);
        }

	[Command( Name = "smug" )]
	public async Task SmugAsync( EventContext e )
	{
		string[] images = new string[]
		{
			"http://i.imgur.com/zUwqrhM.png",
			"http://i.imgur.com/TYqPh89.jpg",
			"http://i.imgur.com/xyOSaCt.png",
			"http://i.imgur.com/gyw0ifl.png",
			"http://i.imgur.com/kk0xvtx.png",
			"http://i.imgur.com/UIuyUne.jpg",
			"http://i.imgur.com/9zgIjY1.jpg",
			"http://i.imgur.com/Ku1ONAD.jpg",
			"http://i.imgur.com/7lB5bRT.jpg",
			"http://i.imgur.com/BoVHipF.jpg",
			"http://i.imgur.com/vN48mwz.png",
			"http://i.imgur.com/fGI4zLe.jpg",
			"http://i.imgur.com/Gc4gmwQ.jpg",
			"http://i.imgur.com/JMrmKt7.jpg",
			"http://i.imgur.com/a7sbJz2.jpg",
			"http://i.imgur.com/NebmjhR.png",
			"http://i.imgur.com/5ccbrFI.png",
			"http://i.imgur.com/XJL4Vmo.jpg",
			"http://i.imgur.com/eg0q1ez.png",
			"http://i.imgur.com/JJFxxmA.jpg",
			"http://i.imgur.com/2cTDF3b.jpg",
			"http://i.imgur.com/Xc0Duqv.png",
			"http://i.imgur.com/YgMdPkd.jpg",
			"http://i.imgur.com/BvAv6an.jpg",
			"http://i.imgur.com/KRLP5JT.jpg",
			"http://i.imgur.com/yXcsCK3.jpg",
			"http://i.imgur.com/QXG56kG.png",
			"http://i.imgur.com/OFBz1YJ.png",
			"http://i.imgur.com/9ulVckY.png",
			"http://i.imgur.com/VLXeSJK.png",
			"http://i.imgur.com/baiMBP6.png"
		};

		RuntimeEmbed em = new RuntimeEmbed( new Discord.EmbedBuilder() )
		{
			ImageUrl = images[Global.random.Next( 0, images.Length )]
		};
		await em.SendToChannel( e.Channel );
	}

	[Command( Name = "cry" )]
	public async Task CryAsync( EventContext e )
	{
		string[] images = new string[]
		{
			"http://i.imgur.com/TTUBf2r.gif",
			"http://i.imgur.com/o66oQyX.png",
			"http://i.imgur.com/6AP78bD.png",
			"http://i.imgur.com/IvMvs2K.gif",
			"http://i.imgur.com/0kdQ38I.gif",
			"http://i.imgur.com/0kdQ38I.gif",
			"http://i.imgur.com/YHYLO4E.gif",
			"http://i.imgur.com/wXqxiDs.gif",
			"http://i.imgur.com/jzafqAh.gif",
			"http://i.imgur.com/2HPoWSf.gif",
			"http://i.imgur.com/W7prbbo.gif",
			"http://i.imgur.com/cKqKcG3.gif",
			"http://i.imgur.com/GKO0EQD.gif",
			"http://i.imgur.com/cu825ub.gif",
			"http://i.imgur.com/TP6dYGh.gif"
		};

		RuntimeEmbed em = new RuntimeEmbed( new Discord.EmbedBuilder() )
		{
			ImageUrl = images[Global.random.Next( 0, images.Length )]
		};
		await em.SendToChannel( e.Channel );
		}
	}
	
        [Command( Name = "f", Aliases = new string[] { "respect" } )]
        public async Task GreentextAsync( EventContext e )
        {
            string[] images = new string[]
            {
                "http://i.imgur.com/WPNM7JY.jpg",
                "http://i.imgur.com/iAlNfsI.png",
                "http://i.imgur.com/FCTtmSR.png",
                "http://i.imgur.com/ATWUuwP.jpg",
                "http://i.imgur.com/tznmDi6.jpg",
                "http://i.imgur.com/RqPQ7Sy.gif",
                "http://i.imgur.com/3K75Z0V.jpg",
                "http://i.imgur.com/j3ZDL9U.gif",
                "http://i.imgur.com/oiXQwb8.jpg",
                "http://i.imgur.com/ssjCUvU.png"
        };
}
