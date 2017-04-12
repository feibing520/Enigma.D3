using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.D3.Collections;
using Enigma.D3.Memory;

namespace Enigma.D3
{
	public class FastAttribGroup : MemoryObject
	{
		// 2.0.1.22044
		public const int SizeOf = 0x9C8;

		public int x000_Id { get { return Read<int>(0x000); } }
		public int x004_Flags { get { return Read<int>(0x004); } }
		public int _x008 { get { return Read<int>(0x008); } }
		public Map<int, AttributeValue> x00C_PtrMap { get { return Dereference<Map<int, AttributeValue>>(0x00C); } }
		public Map<int, AttributeValue> x010_Map { get { return Read<Map<int, AttributeValue>>(0x010); } }
		public int _x074 { get { return Read<int>(0x074); } }
		public int _x078 { get { return Read<int>(0x078); } }
		public int _x07C { get { return Read<int>(0x07C); } }
		public int _x080 { get { return Read<int>(0x080); } }
		public int _x084 { get { return Read<int>(0x084); } }
		public int _x088 { get { return Read<int>(0x088); } }
		public int _x08C { get { return Read<int>(0x08C); } }
		public int _x090 { get { return Read<int>(0x090); } }
		public int _x094 { get { return Read<int>(0x094); } }
		public int _x098 { get { return Read<int>(0x098); } }
		public int _x09C { get { return Read<int>(0x09C); } }
		public int _x0A0 { get { return Read<int>(0x0A0); } }
		public int _x0A4 { get { return Read<int>(0x0A4); } }
		public int _x0A8 { get { return Read<int>(0x0A8); } }
		public int _x0AC { get { return Read<int>(0x0AC); } }
		public int _x0B0 { get { return Read<int>(0x0B0); } }
		public int _x0B4 { get { return Read<int>(0x0B4); } }
		public int _x0B8 { get { return Read<int>(0x0B8); } }
		public int _x0BC { get { return Read<int>(0x0BC); } }
		public int _x0C0 { get { return Read<int>(0x0C0); } }
		public int _x0C4 { get { return Read<int>(0x0C4); } }
		public int _x0C8 { get { return Read<int>(0x0C8); } }
		public int _x0CC { get { return Read<int>(0x0CC); } }
		public int _x0D0 { get { return Read<int>(0x0D0); } }
		public int _x0D4 { get { return Read<int>(0x0D4); } }
		public int _x0D8 { get { return Read<int>(0x0D8); } }
		public int _x0DC { get { return Read<int>(0x0DC); } }
		public int _x0E0 { get { return Read<int>(0x0E0); } }
		public int _x0E4 { get { return Read<int>(0x0E4); } }
		public int _x0E8 { get { return Read<int>(0x0E8); } }
		public int _x0EC { get { return Read<int>(0x0EC); } }
		public int _x0F0 { get { return Read<int>(0x0F0); } }
		public int _x0F4 { get { return Read<int>(0x0F4); } }
		public int _x0F8 { get { return Read<int>(0x0F8); } }
		public int _x0FC { get { return Read<int>(0x0FC); } }
		public int _x100 { get { return Read<int>(0x100); } }
		public int _x104 { get { return Read<int>(0x104); } }
		public int _x108 { get { return Read<int>(0x108); } }
		public int _x10C { get { return Read<int>(0x10C); } }
		public int _x110 { get { return Read<int>(0x110); } }
		public int _x114 { get { return Read<int>(0x114); } }
		public int _x118 { get { return Read<int>(0x118); } }
		public int _x11C { get { return Read<int>(0x11C); } }
		public int _x120 { get { return Read<int>(0x120); } }
		public int _x124 { get { return Read<int>(0x124); } }
		public int _x128 { get { return Read<int>(0x128); } }
		public int _x12C { get { return Read<int>(0x12C); } }
		public int _x130 { get { return Read<int>(0x130); } }
		public int _x134 { get { return Read<int>(0x134); } }
		public int _x138 { get { return Read<int>(0x138); } }
		public int _x13C { get { return Read<int>(0x13C); } }
		public int _x140 { get { return Read<int>(0x140); } }
		public int _x144 { get { return Read<int>(0x144); } }
		public int _x148 { get { return Read<int>(0x148); } }
		public int _x14C { get { return Read<int>(0x14C); } }
		public int _x150 { get { return Read<int>(0x150); } }
		public int _x154 { get { return Read<int>(0x154); } }
		public int _x158 { get { return Read<int>(0x158); } }
		public int _x15C { get { return Read<int>(0x15C); } }
		public int _x160 { get { return Read<int>(0x160); } }
		public int _x164 { get { return Read<int>(0x164); } }
		public int _x168 { get { return Read<int>(0x168); } }
		public int _x16C { get { return Read<int>(0x16C); } }
		public int _x170 { get { return Read<int>(0x170); } }
		public int _x174 { get { return Read<int>(0x174); } }
		public int _x178 { get { return Read<int>(0x178); } }
		public int _x17C { get { return Read<int>(0x17C); } }
		public int _x180 { get { return Read<int>(0x180); } }
		public int _x184 { get { return Read<int>(0x184); } }
		public int _x188 { get { return Read<int>(0x188); } }
		public int _x18C { get { return Read<int>(0x18C); } }
		public int _x190 { get { return Read<int>(0x190); } }
		public int _x194 { get { return Read<int>(0x194); } }
		public int _x198 { get { return Read<int>(0x198); } }
		public int _x19C { get { return Read<int>(0x19C); } }
		public int _x1A0 { get { return Read<int>(0x1A0); } }
		public int _x1A4 { get { return Read<int>(0x1A4); } }
		public int _x1A8 { get { return Read<int>(0x1A8); } }
		public int _x1AC { get { return Read<int>(0x1AC); } }
		public int _x1B0 { get { return Read<int>(0x1B0); } }
		public int _x1B4 { get { return Read<int>(0x1B4); } }
		public int _x1B8 { get { return Read<int>(0x1B8); } }
		public int _x1BC { get { return Read<int>(0x1BC); } }
		public int _x1C0 { get { return Read<int>(0x1C0); } }
		public int _x1C4 { get { return Read<int>(0x1C4); } }
		public int _x1C8 { get { return Read<int>(0x1C8); } }
		public int _x1CC { get { return Read<int>(0x1CC); } }
		public int _x1D0 { get { return Read<int>(0x1D0); } }
		public int _x1D4 { get { return Read<int>(0x1D4); } }
		public int _x1D8 { get { return Read<int>(0x1D8); } }
		public int _x1DC { get { return Read<int>(0x1DC); } }
		public int _x1E0 { get { return Read<int>(0x1E0); } }
		public int _x1E4 { get { return Read<int>(0x1E4); } }
		public int _x1E8 { get { return Read<int>(0x1E8); } }
		public int _x1EC { get { return Read<int>(0x1EC); } }
		public int _x1F0 { get { return Read<int>(0x1F0); } }
		public int _x1F4 { get { return Read<int>(0x1F4); } }
		public int _x1F8 { get { return Read<int>(0x1F8); } }
		public int _x1FC { get { return Read<int>(0x1FC); } }
		public int _x200 { get { return Read<int>(0x200); } }
		public int _x204 { get { return Read<int>(0x204); } }
		public int _x208 { get { return Read<int>(0x208); } }
		public int _x20C { get { return Read<int>(0x20C); } }
		public int _x210 { get { return Read<int>(0x210); } }
		public int _x214 { get { return Read<int>(0x214); } }
		public int _x218 { get { return Read<int>(0x218); } }
		public int _x21C { get { return Read<int>(0x21C); } }
		public int _x220 { get { return Read<int>(0x220); } }
		public int _x224 { get { return Read<int>(0x224); } }
		public int _x228 { get { return Read<int>(0x228); } }
		public int _x22C { get { return Read<int>(0x22C); } }
		public int _x230 { get { return Read<int>(0x230); } }
		public int _x234 { get { return Read<int>(0x234); } }
		public int _x238 { get { return Read<int>(0x238); } }
		public int _x23C { get { return Read<int>(0x23C); } }
		public int _x240 { get { return Read<int>(0x240); } }
		public int _x244 { get { return Read<int>(0x244); } }
		public int _x248 { get { return Read<int>(0x248); } }
		public int _x24C { get { return Read<int>(0x24C); } }
		public int _x250 { get { return Read<int>(0x250); } }
		public int _x254 { get { return Read<int>(0x254); } }
		public int _x258 { get { return Read<int>(0x258); } }
		public int _x25C { get { return Read<int>(0x25C); } }
		public int _x260 { get { return Read<int>(0x260); } }
		public int _x264 { get { return Read<int>(0x264); } }
		public int _x268 { get { return Read<int>(0x268); } }
		public int _x26C { get { return Read<int>(0x26C); } }
		public int _x270 { get { return Read<int>(0x270); } }
		public int _x274 { get { return Read<int>(0x274); } }
		public int _x278 { get { return Read<int>(0x278); } }
		public int _x27C { get { return Read<int>(0x27C); } }
		public int _x280 { get { return Read<int>(0x280); } }
		public int _x284 { get { return Read<int>(0x284); } }
		public int _x288 { get { return Read<int>(0x288); } }
		public int _x28C { get { return Read<int>(0x28C); } }
		public int _x290 { get { return Read<int>(0x290); } }
		public int _x294 { get { return Read<int>(0x294); } }
		public int _x298 { get { return Read<int>(0x298); } }
		public int _x29C { get { return Read<int>(0x29C); } }
		public int _x2A0 { get { return Read<int>(0x2A0); } }
		public int _x2A4 { get { return Read<int>(0x2A4); } }
		public int _x2A8 { get { return Read<int>(0x2A8); } }
		public int _x2AC { get { return Read<int>(0x2AC); } }
		public int _x2B0 { get { return Read<int>(0x2B0); } }
		public int _x2B4 { get { return Read<int>(0x2B4); } }
		public int _x2B8 { get { return Read<int>(0x2B8); } }
		public int _x2BC { get { return Read<int>(0x2BC); } }
		public int _x2C0 { get { return Read<int>(0x2C0); } }
		public int _x2C4 { get { return Read<int>(0x2C4); } }
		public int _x2C8 { get { return Read<int>(0x2C8); } }
		public int _x2CC { get { return Read<int>(0x2CC); } }
		public int _x2D0 { get { return Read<int>(0x2D0); } }
		public int _x2D4 { get { return Read<int>(0x2D4); } }
		public int _x2D8 { get { return Read<int>(0x2D8); } }
		public int _x2DC { get { return Read<int>(0x2DC); } }
		public int _x2E0 { get { return Read<int>(0x2E0); } }
		public int _x2E4 { get { return Read<int>(0x2E4); } }
		public int _x2E8 { get { return Read<int>(0x2E8); } }
		public int _x2EC { get { return Read<int>(0x2EC); } }
		public int _x2F0 { get { return Read<int>(0x2F0); } }
		public int _x2F4 { get { return Read<int>(0x2F4); } }
		public int _x2F8 { get { return Read<int>(0x2F8); } }
		public int _x2FC { get { return Read<int>(0x2FC); } }
		public int _x300 { get { return Read<int>(0x300); } }
		public int _x304 { get { return Read<int>(0x304); } }
		public int _x308 { get { return Read<int>(0x308); } }
		public int _x30C { get { return Read<int>(0x30C); } }
		public int _x310 { get { return Read<int>(0x310); } }
		public int _x314 { get { return Read<int>(0x314); } }
		public int _x318 { get { return Read<int>(0x318); } }
		public int _x31C { get { return Read<int>(0x31C); } }
		public int _x320 { get { return Read<int>(0x320); } }
		public int _x324 { get { return Read<int>(0x324); } }
		public int _x328 { get { return Read<int>(0x328); } }
		public int _x32C { get { return Read<int>(0x32C); } }
		public int _x330 { get { return Read<int>(0x330); } }
		public int _x334 { get { return Read<int>(0x334); } }
		public int _x338 { get { return Read<int>(0x338); } }
		public int _x33C { get { return Read<int>(0x33C); } }
		public int _x340 { get { return Read<int>(0x340); } }
		public int _x344 { get { return Read<int>(0x344); } }
		public int _x348 { get { return Read<int>(0x348); } }
		public int _x34C { get { return Read<int>(0x34C); } }
		public int _x350 { get { return Read<int>(0x350); } }
		public int _x354 { get { return Read<int>(0x354); } }
		public int _x358 { get { return Read<int>(0x358); } }
		public int _x35C { get { return Read<int>(0x35C); } }
		public int _x360 { get { return Read<int>(0x360); } }
		public int _x364 { get { return Read<int>(0x364); } }
		public int _x368 { get { return Read<int>(0x368); } }
		public int _x36C { get { return Read<int>(0x36C); } }
		public int _x370 { get { return Read<int>(0x370); } }
		public int _x374 { get { return Read<int>(0x374); } }
		public int _x378 { get { return Read<int>(0x378); } }
		public int _x37C { get { return Read<int>(0x37C); } }
		public int _x380 { get { return Read<int>(0x380); } }
		public int _x384 { get { return Read<int>(0x384); } }
		public int _x388 { get { return Read<int>(0x388); } }
		public int _x38C { get { return Read<int>(0x38C); } }
		public int _x390 { get { return Read<int>(0x390); } }
		public int _x394 { get { return Read<int>(0x394); } }
		public int _x398 { get { return Read<int>(0x398); } }
		public int _x39C { get { return Read<int>(0x39C); } }
		public int _x3A0 { get { return Read<int>(0x3A0); } }
		public int _x3A4 { get { return Read<int>(0x3A4); } }
		public int _x3A8 { get { return Read<int>(0x3A8); } }
		public int _x3AC { get { return Read<int>(0x3AC); } }
		public int _x3B0 { get { return Read<int>(0x3B0); } }
		public int _x3B4 { get { return Read<int>(0x3B4); } }
		public int _x3B8 { get { return Read<int>(0x3B8); } }
		public int _x3BC { get { return Read<int>(0x3BC); } }
		public int _x3C0 { get { return Read<int>(0x3C0); } }
		public int _x3C4 { get { return Read<int>(0x3C4); } }
		public int _x3C8 { get { return Read<int>(0x3C8); } }
		public int _x3CC { get { return Read<int>(0x3CC); } }
		public int _x3D0 { get { return Read<int>(0x3D0); } }
		public int _x3D4 { get { return Read<int>(0x3D4); } }
		public int _x3D8 { get { return Read<int>(0x3D8); } }
		public int _x3DC { get { return Read<int>(0x3DC); } }
		public int _x3E0 { get { return Read<int>(0x3E0); } }
		public int _x3E4 { get { return Read<int>(0x3E4); } }
		public int _x3E8 { get { return Read<int>(0x3E8); } }
		public int _x3EC { get { return Read<int>(0x3EC); } }
		public int _x3F0 { get { return Read<int>(0x3F0); } }
		public int _x3F4 { get { return Read<int>(0x3F4); } }
		public int _x3F8 { get { return Read<int>(0x3F8); } }
		public int _x3FC { get { return Read<int>(0x3FC); } }
		public int _x400 { get { return Read<int>(0x400); } }
		public int _x404 { get { return Read<int>(0x404); } }
		public int _x408 { get { return Read<int>(0x408); } }
		public int _x40C { get { return Read<int>(0x40C); } }
		public int _x410 { get { return Read<int>(0x410); } }
		public int _x414 { get { return Read<int>(0x414); } }
		public int _x418 { get { return Read<int>(0x418); } }
		public int _x41C { get { return Read<int>(0x41C); } }
		public int _x420 { get { return Read<int>(0x420); } }
		public int _x424 { get { return Read<int>(0x424); } }
		public int _x428 { get { return Read<int>(0x428); } }
		public int _x42C { get { return Read<int>(0x42C); } }
		public int _x430 { get { return Read<int>(0x430); } }
		public int _x434 { get { return Read<int>(0x434); } }
		public int x438_StructStart { get { return Read<int>(0x438); } }
		public int _x43C { get { return Read<int>(0x43C); } }
		public int _x440 { get { return Read<int>(0x440); } }
		public int _x444 { get { return Read<int>(0x444); } }
		public int _x448 { get { return Read<int>(0x448); } }
		public int _x44C { get { return Read<int>(0x44C); } }
		public int _x450 { get { return Read<int>(0x450); } }
		public int _x454 { get { return Read<int>(0x454); } }
		public int _x458 { get { return Read<int>(0x458); } }
		public int _x45C { get { return Read<int>(0x45C); } }
		public int _x460 { get { return Read<int>(0x460); } }
		public int _x464 { get { return Read<int>(0x464); } }
		public int _x468 { get { return Read<int>(0x468); } }
		public int _x46C { get { return Read<int>(0x46C); } }
		public int _x470 { get { return Read<int>(0x470); } }
		public int _x474 { get { return Read<int>(0x474); } }
		public int _x478 { get { return Read<int>(0x478); } }
		public int _x47C { get { return Read<int>(0x47C); } }
		public int _x480 { get { return Read<int>(0x480); } }
		public int _x484 { get { return Read<int>(0x484); } }
		public int _x488 { get { return Read<int>(0x488); } }
		public int _x48C { get { return Read<int>(0x48C); } }
		public int _x490 { get { return Read<int>(0x490); } }
		public int _x494 { get { return Read<int>(0x494); } }
		public int _x498 { get { return Read<int>(0x498); } }
		public int _x49C { get { return Read<int>(0x49C); } }
		public int _x4A0 { get { return Read<int>(0x4A0); } }
		public int _x4A4 { get { return Read<int>(0x4A4); } }
		public int _x4A8 { get { return Read<int>(0x4A8); } }
		public int _x4AC { get { return Read<int>(0x4AC); } }
		public int _x4B0 { get { return Read<int>(0x4B0); } }
		public int _x4B4 { get { return Read<int>(0x4B4); } }
		public int _x4B8 { get { return Read<int>(0x4B8); } }
		public int _x4BC { get { return Read<int>(0x4BC); } }
		public int _x4C0 { get { return Read<int>(0x4C0); } }
		public int _x4C4 { get { return Read<int>(0x4C4); } }
		public int _x4C8 { get { return Read<int>(0x4C8); } }
		public int _x4CC { get { return Read<int>(0x4CC); } }
		public int _x4D0 { get { return Read<int>(0x4D0); } }
		public int _x4D4 { get { return Read<int>(0x4D4); } }
		public int _x4D8 { get { return Read<int>(0x4D8); } }
		public int _x4DC { get { return Read<int>(0x4DC); } }
		public int _x4E0 { get { return Read<int>(0x4E0); } }
		public int _x4E4 { get { return Read<int>(0x4E4); } }
		public int _x4E8 { get { return Read<int>(0x4E8); } }
		public int _x4EC { get { return Read<int>(0x4EC); } }
		public int _x4F0 { get { return Read<int>(0x4F0); } }
		public int _x4F4 { get { return Read<int>(0x4F4); } }
		public int _x4F8 { get { return Read<int>(0x4F8); } }
		public int _x4FC { get { return Read<int>(0x4FC); } }
		public int _x500 { get { return Read<int>(0x500); } }
		public int _x504 { get { return Read<int>(0x504); } }
		public int _x508 { get { return Read<int>(0x508); } }
		public int _x50C { get { return Read<int>(0x50C); } }
		public int _x510 { get { return Read<int>(0x510); } }
		public int _x514 { get { return Read<int>(0x514); } }
		public int _x518 { get { return Read<int>(0x518); } }
		public int _x51C { get { return Read<int>(0x51C); } }
		public int _x520 { get { return Read<int>(0x520); } }
		public int _x524 { get { return Read<int>(0x524); } }
		public int _x528 { get { return Read<int>(0x528); } }
		public int _x52C { get { return Read<int>(0x52C); } }
		public int _x530 { get { return Read<int>(0x530); } }
		public int _x534 { get { return Read<int>(0x534); } }
		public int _x538 { get { return Read<int>(0x538); } }
		public int _x53C { get { return Read<int>(0x53C); } }
		public int _x540 { get { return Read<int>(0x540); } }
		public int _x544 { get { return Read<int>(0x544); } }
		public int _x548 { get { return Read<int>(0x548); } }
		public int _x54C { get { return Read<int>(0x54C); } }
		public int _x550 { get { return Read<int>(0x550); } }
		public int _x554 { get { return Read<int>(0x554); } }
		public int _x558 { get { return Read<int>(0x558); } }
		public int _x55C { get { return Read<int>(0x55C); } }
		public int _x560 { get { return Read<int>(0x560); } }
		public int _x564 { get { return Read<int>(0x564); } }
		public int _x568 { get { return Read<int>(0x568); } }
		public int _x56C { get { return Read<int>(0x56C); } }
		public int _x570 { get { return Read<int>(0x570); } }
		public int _x574 { get { return Read<int>(0x574); } }
		public int _x578 { get { return Read<int>(0x578); } }
		public int _x57C { get { return Read<int>(0x57C); } }
		public int _x580 { get { return Read<int>(0x580); } }
		public int _x584 { get { return Read<int>(0x584); } }
		public int _x588 { get { return Read<int>(0x588); } }
		public int _x58C { get { return Read<int>(0x58C); } }
		public int _x590 { get { return Read<int>(0x590); } }
		public int _x594 { get { return Read<int>(0x594); } }
		public int _x598 { get { return Read<int>(0x598); } }
		public int _x59C { get { return Read<int>(0x59C); } }
		public int _x5A0 { get { return Read<int>(0x5A0); } }
		public int _x5A4 { get { return Read<int>(0x5A4); } }
		public int _x5A8 { get { return Read<int>(0x5A8); } }
		public int _x5AC { get { return Read<int>(0x5AC); } }
		public int _x5B0 { get { return Read<int>(0x5B0); } }
		public int _x5B4 { get { return Read<int>(0x5B4); } }
		public int _x5B8 { get { return Read<int>(0x5B8); } }
		public int _x5BC { get { return Read<int>(0x5BC); } }
		public int _x5C0 { get { return Read<int>(0x5C0); } }
		public int _x5C4 { get { return Read<int>(0x5C4); } }
		public int _x5C8 { get { return Read<int>(0x5C8); } }
		public int _x5CC { get { return Read<int>(0x5CC); } }
		public int _x5D0 { get { return Read<int>(0x5D0); } }
		public int _x5D4 { get { return Read<int>(0x5D4); } }
		public int _x5D8 { get { return Read<int>(0x5D8); } }
		public int _x5DC { get { return Read<int>(0x5DC); } }
		public int _x5E0 { get { return Read<int>(0x5E0); } }
		public int _x5E4 { get { return Read<int>(0x5E4); } }
		public int _x5E8 { get { return Read<int>(0x5E8); } }
		public int _x5EC { get { return Read<int>(0x5EC); } }
		public int _x5F0 { get { return Read<int>(0x5F0); } }
		public int _x5F4 { get { return Read<int>(0x5F4); } }
		public int _x5F8 { get { return Read<int>(0x5F8); } }
		public int _x5FC { get { return Read<int>(0x5FC); } }
		public int _x600 { get { return Read<int>(0x600); } }
		public int _x604 { get { return Read<int>(0x604); } }
		public int _x608 { get { return Read<int>(0x608); } }
		public int _x60C { get { return Read<int>(0x60C); } }
		public int _x610 { get { return Read<int>(0x610); } }
		public int _x614 { get { return Read<int>(0x614); } }
		public int _x618 { get { return Read<int>(0x618); } }
		public int _x61C { get { return Read<int>(0x61C); } }
		public int _x620 { get { return Read<int>(0x620); } }
		public int _x624 { get { return Read<int>(0x624); } }
		public int _x628 { get { return Read<int>(0x628); } }
		public int _x62C { get { return Read<int>(0x62C); } }
		public int _x630 { get { return Read<int>(0x630); } }
		public int _x634 { get { return Read<int>(0x634); } }
		public int _x638 { get { return Read<int>(0x638); } }
		public int _x63C { get { return Read<int>(0x63C); } }
		public int _x640 { get { return Read<int>(0x640); } }
		public int _x644 { get { return Read<int>(0x644); } }
		public int _x648 { get { return Read<int>(0x648); } }
		public int _x64C { get { return Read<int>(0x64C); } }
		public int _x650 { get { return Read<int>(0x650); } }
		public int _x654 { get { return Read<int>(0x654); } }
		public int _x658 { get { return Read<int>(0x658); } }
		public int _x65C { get { return Read<int>(0x65C); } }
		public int _x660 { get { return Read<int>(0x660); } }
		public int _x664 { get { return Read<int>(0x664); } }
		public int _x668 { get { return Read<int>(0x668); } }
		public int _x66C { get { return Read<int>(0x66C); } }
		public int _x670 { get { return Read<int>(0x670); } }
		public int _x674 { get { return Read<int>(0x674); } }
		public int _x678 { get { return Read<int>(0x678); } }
		public int _x67C { get { return Read<int>(0x67C); } }
		public int _x680 { get { return Read<int>(0x680); } }
		public int _x684 { get { return Read<int>(0x684); } }
		public int _x688 { get { return Read<int>(0x688); } }
		public int _x68C { get { return Read<int>(0x68C); } }
		public int _x690 { get { return Read<int>(0x690); } }
		public int _x694 { get { return Read<int>(0x694); } }
		public int _x698 { get { return Read<int>(0x698); } }
		public int _x69C { get { return Read<int>(0x69C); } }
		public int _x6A0 { get { return Read<int>(0x6A0); } }
		public int _x6A4 { get { return Read<int>(0x6A4); } }
		public int _x6A8 { get { return Read<int>(0x6A8); } }
		public int _x6AC { get { return Read<int>(0x6AC); } }
		public int _x6B0 { get { return Read<int>(0x6B0); } }
		public int _x6B4 { get { return Read<int>(0x6B4); } }
		public int _x6B8 { get { return Read<int>(0x6B8); } }
		public int _x6BC { get { return Read<int>(0x6BC); } }
		public int _x6C0 { get { return Read<int>(0x6C0); } }
		public int _x6C4 { get { return Read<int>(0x6C4); } }
		public int _x6C8 { get { return Read<int>(0x6C8); } }
		public int _x6CC { get { return Read<int>(0x6CC); } }
		public int _x6D0 { get { return Read<int>(0x6D0); } }
		public int _x6D4 { get { return Read<int>(0x6D4); } }
		public int _x6D8 { get { return Read<int>(0x6D8); } }
		public int _x6DC { get { return Read<int>(0x6DC); } }
		public int _x6E0 { get { return Read<int>(0x6E0); } }
		public int _x6E4 { get { return Read<int>(0x6E4); } }
		public int _x6E8 { get { return Read<int>(0x6E8); } }
		public int _x6EC { get { return Read<int>(0x6EC); } }
		public int _x6F0 { get { return Read<int>(0x6F0); } }
		public int _x6F4 { get { return Read<int>(0x6F4); } }
		public int _x6F8 { get { return Read<int>(0x6F8); } }
		public int _x6FC { get { return Read<int>(0x6FC); } }
		public int _x700 { get { return Read<int>(0x700); } }
		public int _x704 { get { return Read<int>(0x704); } }
		public int _x708 { get { return Read<int>(0x708); } }
		public int _x70C { get { return Read<int>(0x70C); } }
		public int _x710 { get { return Read<int>(0x710); } }
		public int _x714 { get { return Read<int>(0x714); } }
		public int _x718 { get { return Read<int>(0x718); } }
		public int _x71C { get { return Read<int>(0x71C); } }
		public int _x720 { get { return Read<int>(0x720); } }
		public int _x724 { get { return Read<int>(0x724); } }
		public int _x728 { get { return Read<int>(0x728); } }
		public int _x72C { get { return Read<int>(0x72C); } }
		public int _x730 { get { return Read<int>(0x730); } }
		public int _x734 { get { return Read<int>(0x734); } }
		public int _x738 { get { return Read<int>(0x738); } }
		public int _x73C { get { return Read<int>(0x73C); } }
		public int _x740 { get { return Read<int>(0x740); } }
		public int _x744 { get { return Read<int>(0x744); } }
		public int _x748 { get { return Read<int>(0x748); } }
		public int _x74C { get { return Read<int>(0x74C); } }
		public int _x750 { get { return Read<int>(0x750); } }
		public int _x754 { get { return Read<int>(0x754); } }
		public int _x758 { get { return Read<int>(0x758); } }
		public int _x75C { get { return Read<int>(0x75C); } }
		public int _x760 { get { return Read<int>(0x760); } }
		public int _x764 { get { return Read<int>(0x764); } }
		public int _x768 { get { return Read<int>(0x768); } }
		public int _x76C { get { return Read<int>(0x76C); } }
		public int _x770 { get { return Read<int>(0x770); } }
		public int _x774 { get { return Read<int>(0x774); } }
		public int _x778 { get { return Read<int>(0x778); } }
		public int _x77C { get { return Read<int>(0x77C); } }
		public int _x780 { get { return Read<int>(0x780); } }
		public int _x784 { get { return Read<int>(0x784); } }
		public int _x788 { get { return Read<int>(0x788); } }
		public int _x78C { get { return Read<int>(0x78C); } }
		public int _x790 { get { return Read<int>(0x790); } }
		public int _x794 { get { return Read<int>(0x794); } }
		public int _x798 { get { return Read<int>(0x798); } }
		public int _x79C { get { return Read<int>(0x79C); } }
		public int _x7A0 { get { return Read<int>(0x7A0); } }
		public int _x7A4 { get { return Read<int>(0x7A4); } }
		public int _x7A8 { get { return Read<int>(0x7A8); } }
		public int _x7AC { get { return Read<int>(0x7AC); } }
		public int _x7B0 { get { return Read<int>(0x7B0); } }
		public int _x7B4 { get { return Read<int>(0x7B4); } }
		public int _x7B8 { get { return Read<int>(0x7B8); } }
		public int _x7BC { get { return Read<int>(0x7BC); } }
		public int _x7C0 { get { return Read<int>(0x7C0); } }
		public int _x7C4 { get { return Read<int>(0x7C4); } }
		public int _x7C8 { get { return Read<int>(0x7C8); } }
		public int _x7CC { get { return Read<int>(0x7CC); } }
		public int _x7D0 { get { return Read<int>(0x7D0); } }
		public int _x7D4 { get { return Read<int>(0x7D4); } }
		public int _x7D8 { get { return Read<int>(0x7D8); } }
		public int _x7DC { get { return Read<int>(0x7DC); } }
		public int _x7E0 { get { return Read<int>(0x7E0); } }
		public int _x7E4 { get { return Read<int>(0x7E4); } }
		public int _x7E8 { get { return Read<int>(0x7E8); } }
		public int _x7EC { get { return Read<int>(0x7EC); } }
		public int _x7F0 { get { return Read<int>(0x7F0); } }
		public int _x7F4 { get { return Read<int>(0x7F4); } }
		public int _x7F8 { get { return Read<int>(0x7F8); } }
		public int _x7FC { get { return Read<int>(0x7FC); } }
		public int _x800 { get { return Read<int>(0x800); } }
		public int _x804 { get { return Read<int>(0x804); } }
		public int _x808 { get { return Read<int>(0x808); } }
		public int _x80C { get { return Read<int>(0x80C); } }
		public int _x810 { get { return Read<int>(0x810); } }
		public int _x814 { get { return Read<int>(0x814); } }
		public int _x818 { get { return Read<int>(0x818); } }
		public int _x81C { get { return Read<int>(0x81C); } }
		public int _x820 { get { return Read<int>(0x820); } }
		public int _x824 { get { return Read<int>(0x824); } }
		public int _x828 { get { return Read<int>(0x828); } }
		public int _x82C { get { return Read<int>(0x82C); } }
		public int _x830 { get { return Read<int>(0x830); } }
		public int _x834 { get { return Read<int>(0x834); } }
		public int _x838 { get { return Read<int>(0x838); } }
		public int _x83C { get { return Read<int>(0x83C); } }
		public int _x840 { get { return Read<int>(0x840); } }
		public int _x844 { get { return Read<int>(0x844); } }
		public int _x848 { get { return Read<int>(0x848); } }
		public int _x84C { get { return Read<int>(0x84C); } }
		public int _x850 { get { return Read<int>(0x850); } }
		public int _x854 { get { return Read<int>(0x854); } }
		public int _x858 { get { return Read<int>(0x858); } }
		public int _x85C { get { return Read<int>(0x85C); } }
		public int x860 { get { return Read<int>(0x860); } }
		public int x864 { get { return Read<int>(0x864); } }
		public int _x868 { get { return Read<int>(0x868); } }
		public int _x86C { get { return Read<int>(0x86C); } }
		public int _x870 { get { return Read<int>(0x870); } }
		public int _x874 { get { return Read<int>(0x874); } }
		public int x878_Map { get { return Read<int>(0x878); } }
		public int _x87C { get { return Read<int>(0x87C); } }
		public int _x880 { get { return Read<int>(0x880); } }
		public int _x884 { get { return Read<int>(0x884); } }
		public int x888 { get { return Read<int>(0x888); } }
		public int _x88C { get { return Read<int>(0x88C); } }
		public int _x890 { get { return Read<int>(0x890); } }
		public int _x894 { get { return Read<int>(0x894); } }
		public int _x898 { get { return Read<int>(0x898); } }
		public int _x89C { get { return Read<int>(0x89C); } }
		public int _x8A0 { get { return Read<int>(0x8A0); } }
		public int _x8A4 { get { return Read<int>(0x8A4); } }
		public int _x8A8 { get { return Read<int>(0x8A8); } }
		public int _x8AC { get { return Read<int>(0x8AC); } }
		public int _x8B0 { get { return Read<int>(0x8B0); } }
		public int _x8B4 { get { return Read<int>(0x8B4); } }
		public int _x8B8 { get { return Read<int>(0x8B8); } }
		public int _x8BC { get { return Read<int>(0x8BC); } }
		public int _x8C0 { get { return Read<int>(0x8C0); } }
		public int _x8C4 { get { return Read<int>(0x8C4); } }
		public int _x8C8 { get { return Read<int>(0x8C8); } }
		public int _x8CC { get { return Read<int>(0x8CC); } }
		public int _x8D0 { get { return Read<int>(0x8D0); } }
		public int _x8D4 { get { return Read<int>(0x8D4); } }
		public int _x8D8 { get { return Read<int>(0x8D8); } }
		public int _x8DC { get { return Read<int>(0x8DC); } }
		public int _x8E0 { get { return Read<int>(0x8E0); } }
		public int _x8E4 { get { return Read<int>(0x8E4); } }
		public int _x8E8 { get { return Read<int>(0x8E8); } }
		public int _x8EC { get { return Read<int>(0x8EC); } }
		public int _x8F0 { get { return Read<int>(0x8F0); } }
		public int _x8F4 { get { return Read<int>(0x8F4); } }
		public int _x8F8 { get { return Read<int>(0x8F8); } }
		public int _x8FC { get { return Read<int>(0x8FC); } }
		public int _x900 { get { return Read<int>(0x900); } }
		public int _x904 { get { return Read<int>(0x904); } }
		public int _x908 { get { return Read<int>(0x908); } }
		public int _x90C { get { return Read<int>(0x90C); } }
		public int _x910 { get { return Read<int>(0x910); } }
		public int _x914 { get { return Read<int>(0x914); } }
		public int _x918 { get { return Read<int>(0x918); } }
		public int _x91C { get { return Read<int>(0x91C); } }
		public int _x920 { get { return Read<int>(0x920); } }
		public int _x924 { get { return Read<int>(0x924); } }
		public int _x928 { get { return Read<int>(0x928); } }
		public int _x92C { get { return Read<int>(0x92C); } }
		public int _x930 { get { return Read<int>(0x930); } }
		public int _x934 { get { return Read<int>(0x934); } }
		public int _x938 { get { return Read<int>(0x938); } }
		public int _x93C { get { return Read<int>(0x93C); } }
		public int _x940 { get { return Read<int>(0x940); } }
		public int _x944 { get { return Read<int>(0x944); } }
		public int _x948 { get { return Read<int>(0x948); } }
		public int _x94C { get { return Read<int>(0x94C); } }
		public int _x950 { get { return Read<int>(0x950); } }
		public int _x954 { get { return Read<int>(0x954); } }
		public int _x958 { get { return Read<int>(0x958); } }
		public int _x95C { get { return Read<int>(0x95C); } }
		public int _x960 { get { return Read<int>(0x960); } }
		public int _x964 { get { return Read<int>(0x964); } }
		public int _x968 { get { return Read<int>(0x968); } }
		public int _x96C { get { return Read<int>(0x96C); } }
		public int _x970 { get { return Read<int>(0x970); } }
		public int _x974 { get { return Read<int>(0x974); } }
		public int _x978 { get { return Read<int>(0x978); } }
		public int _x97C { get { return Read<int>(0x97C); } }
		public int _x980 { get { return Read<int>(0x980); } }
		public int _x984 { get { return Read<int>(0x984); } }
		public int _x988 { get { return Read<int>(0x988); } }
		public int _x98C { get { return Read<int>(0x98C); } }
		public int _x990 { get { return Read<int>(0x990); } }
		public int _x994 { get { return Read<int>(0x994); } }
		public int _x998 { get { return Read<int>(0x998); } }
		public int _x99C { get { return Read<int>(0x99C); } }
		public int _x9A0 { get { return Read<int>(0x9A0); } }
		public int _x9A4 { get { return Read<int>(0x9A4); } }
		public int _x9A8 { get { return Read<int>(0x9A8); } }
		public int _x9AC { get { return Read<int>(0x9AC); } }
		public int _x9B0 { get { return Read<int>(0x9B0); } }
		public int _x9B4 { get { return Read<int>(0x9B4); } }
		public int _x9B8 { get { return Read<int>(0x9B8); } }
		public int _x9BC { get { return Read<int>(0x9BC); } }
		public int _x9C0 { get { return Read<int>(0x9C0); } }
		public int _x9C4 { get { return Read<int>(0x9C4); } }

		public static FastAttribGroup Get(int groupId)
		{
			return FastAttrib.Instance?.x54_Groups[(short)groupId];
		}
	}
}
