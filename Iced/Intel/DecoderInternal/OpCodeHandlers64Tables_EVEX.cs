/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if !NO_DECODER64 && !NO_DECODER
namespace Iced.Intel.DecoderInternal.OpCodeHandlers64 {
	/// <summary>
	/// Handlers for 64-bit mode (EVEX)
	/// </summary>
	static class OpCodeHandlers64Tables_EVEX {
		internal static readonly OpCodeHandler[] ThreeByteHandlers_0F38XX;
		internal static readonly OpCodeHandler[] ThreeByteHandlers_0F3AXX;
		internal static readonly OpCodeHandler[] TwoByteHandlers_0FXX;

		static OpCodeHandlers64Tables_EVEX() {
			// Store it in a local. Instead of 1500+ ldfld, we'll have 1500+ ldloc.0 (save 4 bytes per load)
			var invalid = OpCodeHandler_Invalid.Instance;

			var handlers_Grp_0F71 = new OpCodeHandler[8] {
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpsrlw_xmm_k1z_xmmm128_imm8, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpsrlw_ymm_k1z_ymmm256_imm8, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpsrlw_zmm_k1z_zmmm512_imm8, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpsraw_xmm_k1z_xmmm128_imm8, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpsraw_ymm_k1z_ymmm256_imm8, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpsraw_zmm_k1z_zmmm512_imm8, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpsllw_xmm_k1z_xmmm128_imm8, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpsllw_ymm_k1z_ymmm256_imm8, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpsllw_zmm_k1z_zmmm512_imm8, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				invalid,
			};

			var handlers_Grp_0F72 = new OpCodeHandler[8] {
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vprord_xmm_k1z_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vprord_ymm_k1z_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vprord_zmm_k1z_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vprorq_xmm_k1z_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vprorq_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vprorq_zmm_k1z_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vprold_xmm_k1z_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vprold_ymm_k1z_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vprold_zmm_k1z_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vprolq_xmm_k1z_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vprolq_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vprolq_zmm_k1z_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpsrld_xmm_k1z_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpsrld_ymm_k1z_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpsrld_zmm_k1z_zmmm512b32_imm8, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpsrad_xmm_k1z_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpsrad_ymm_k1z_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpsrad_zmm_k1z_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpsraq_xmm_k1z_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpsraq_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpsraq_zmm_k1z_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpslld_xmm_k1z_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpslld_ymm_k1z_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpslld_zmm_k1z_zmmm512b32_imm8, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				invalid,
			};

			var handlers_Grp_0F73 = new OpCodeHandler[8] {
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpsrlq_xmm_k1z_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpsrlq_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpsrlq_zmm_k1z_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpsrldq_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpsrldq_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpsrldq_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpsllq_xmm_k1z_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpsllq_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpsllq_zmm_k1z_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_HkWIb(Register.XMM0, Code.EVEX_Vpslldq_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_HkWIb(Register.YMM0, Code.EVEX_Vpslldq_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_HkWIb(Register.ZMM0, Code.EVEX_Vpslldq_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
			};

			var handlers_Grp_0F38C6 = new OpCodeHandler[8] {
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vgatherpf0dps_vm32z_k1, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.YMM0, Code.EVEX_Vgatherpf0dpd_vm32y_k1, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vgatherpf1dps_vm32z_k1, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.YMM0, Code.EVEX_Vgatherpf1dpd_vm32y_k1, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vscatterpf0dps_vm32z_k1, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.YMM0, Code.EVEX_Vscatterpf0dpd_vm32y_k1, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vscatterpf1dps_vm32z_k1, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.YMM0, Code.EVEX_Vscatterpf1dpd_vm32y_k1, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				invalid,
			};

			var handlers_Grp_0F38C7 = new OpCodeHandler[8] {
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vgatherpf0qps_vm64z_k1, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vgatherpf0qpd_vm64z_k1, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vgatherpf1qps_vm64z_k1, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vgatherpf1qpd_vm64z_k1, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vscatterpf0qps_vm64z_k1, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vscatterpf0qpd_vm64z_k1, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vscatterpf1qps_vm64z_k1, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VSIB_k1(Register.ZMM0, Code.EVEX_Vscatterpf1qpd_vm64z_k1, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				invalid,
			};

			ThreeByteHandlers_0F38XX = new OpCodeHandler[0x100] {
				// 00
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpshufb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpshufb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpshufb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmaddubsw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmaddubsw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmaddubsw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				invalid,

				// 08
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmulhrsw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmulhrsw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmulhrsw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermilps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermilps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermilps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermilpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermilpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermilpd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,

				// 10
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsrlvw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsrlvw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsrlvw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovuswb_xmmm64_k1z_xmm, TupleType.Half_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovuswb_xmmm128_k1z_ymm, TupleType.Half_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Register.ZMM0, Code.EVEX_Vpmovuswb_ymmm256_k1z_zmm, TupleType.Half_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsravw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsravw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsravw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovusdb_xmmm32_k1z_xmm, TupleType.Quarter_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovusdb_xmmm64_k1z_ymm, TupleType.Quarter_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.ZMM0, Code.EVEX_Vpmovusdb_xmmm128_k1z_zmm, TupleType.Quarter_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsllvw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsllvw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsllvw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovusqb_xmmm16_k1z_xmm, TupleType.Eighth_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovusqb_xmmm32_k1z_ymm, TupleType.Eighth_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.ZMM0, Code.EVEX_Vpmovusqb_xmmm64_k1z_zmm, TupleType.Eighth_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtph2ps_xmm_k1z_xmmm64, TupleType.Half_Mem_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.XMM0, Code.EVEX_Vcvtph2ps_ymm_k1z_xmmm128, TupleType.Half_Mem_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.YMM0, Code.EVEX_Vcvtph2ps_zmm_k1z_ymmm256_sae, TupleType.Half_Mem_512, onlySAE: true)
						),
						invalid
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovusdw_xmmm64_k1z_xmm, TupleType.Half_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovusdw_xmmm128_k1z_ymm, TupleType.Half_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Register.ZMM0, Code.EVEX_Vpmovusdw_ymmm256_k1z_zmm, TupleType.Half_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vprorvd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vprorvd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vprorvd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vprorvq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vprorvq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vprorvq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovusqw_xmmm32_k1z_xmm, TupleType.Quarter_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovusqw_xmmm64_k1z_ymm, TupleType.Quarter_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.ZMM0, Code.EVEX_Vpmovusqw_xmmm128_k1z_zmm, TupleType.Quarter_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vprolvd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vprolvd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vprolvd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vprolvq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vprolvq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vprolvq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovusqd_xmmm64_k1z_xmm, TupleType.Half_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovusqd_xmmm128_k1z_ymm, TupleType.Half_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Register.ZMM0, Code.EVEX_Vpmovusqd_ymmm256_k1z_zmm, TupleType.Half_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermpd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,

				// 18
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vbroadcastss_xmm_k1z_xmmm32, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vbroadcastss_ymm_k1z_xmmm32, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vbroadcastss_zmm_k1z_xmmm32, TupleType.Tuple1_Scalar)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vbroadcastf32x2_ymm_k1z_xmmm64, TupleType.Tuple2),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vbroadcastf32x2_zmm_k1z_xmmm64, TupleType.Tuple2)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vbroadcastsd_ymm_k1z_xmmm64, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vbroadcastsd_zmm_k1z_xmmm64, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkM(Register.YMM0, Code.EVEX_Vbroadcastf32x4_ymm_k1z_m128, TupleType.Tuple4),
							new OpCodeHandler_EVEX_VkM(Register.ZMM0, Code.EVEX_Vbroadcastf32x4_zmm_k1z_m128, TupleType.Tuple4)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkM(Register.YMM0, Code.EVEX_Vbroadcastf64x2_ymm_k1z_m128, TupleType.Tuple2),
							new OpCodeHandler_EVEX_VkM(Register.ZMM0, Code.EVEX_Vbroadcastf64x2_zmm_k1z_m128, TupleType.Tuple2)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkM(Register.ZMM0, Code.EVEX_Vbroadcastf32x8_zmm_k1z_m256, TupleType.Tuple8)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkM(Register.ZMM0, Code.EVEX_Vbroadcastf64x4_zmm_k1z_m256, TupleType.Tuple4)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpabsb_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpabsb_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpabsb_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpabsw_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpabsw_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpabsw_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpabsd_xmm_k1z_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpabsd_ymm_k1z_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpabsd_zmm_k1z_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpabsq_xmm_k1z_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpabsq_ymm_k1z_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpabsq_zmm_k1z_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// 20
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsxbw_xmm_k1z_xmmm64, TupleType.Half_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovsxbw_ymm_k1z_xmmm128, TupleType.Half_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.YMM0, Code.EVEX_Vpmovsxbw_zmm_k1z_ymmm256, TupleType.Half_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovswb_xmmm64_k1z_xmm, TupleType.Half_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovswb_xmmm128_k1z_ymm, TupleType.Half_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Register.ZMM0, Code.EVEX_Vpmovswb_ymmm256_k1z_zmm, TupleType.Half_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsxbd_xmm_k1z_xmmm32, TupleType.Quarter_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovsxbd_ymm_k1z_xmmm64, TupleType.Quarter_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vpmovsxbd_zmm_k1z_xmmm128, TupleType.Quarter_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsdb_xmmm32_k1z_xmm, TupleType.Quarter_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovsdb_xmmm64_k1z_ymm, TupleType.Quarter_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.ZMM0, Code.EVEX_Vpmovsdb_xmmm128_k1z_zmm, TupleType.Quarter_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsxbq_xmm_k1z_xmmm16, TupleType.Eighth_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovsxbq_ymm_k1z_xmmm32, TupleType.Eighth_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vpmovsxbq_zmm_k1z_xmmm64, TupleType.Eighth_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsqb_xmmm16_k1z_xmm, TupleType.Eighth_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovsqb_xmmm32_k1z_ymm, TupleType.Eighth_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.ZMM0, Code.EVEX_Vpmovsqb_xmmm64_k1z_zmm, TupleType.Eighth_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsxwd_xmm_k1z_xmmm64, TupleType.Half_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovsxwd_ymm_k1z_xmmm128, TupleType.Half_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.YMM0, Code.EVEX_Vpmovsxwd_zmm_k1z_ymmm256, TupleType.Half_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsdw_xmmm64_k1z_xmm, TupleType.Half_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovsdw_xmmm128_k1z_ymm, TupleType.Half_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Register.ZMM0, Code.EVEX_Vpmovsdw_ymmm256_k1z_zmm, TupleType.Half_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsxwq_xmm_k1z_xmmm32, TupleType.Quarter_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovsxwq_ymm_k1z_xmmm64, TupleType.Quarter_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vpmovsxwq_zmm_k1z_xmmm128, TupleType.Quarter_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsqw_xmmm32_k1z_xmm, TupleType.Quarter_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovsqw_xmmm64_k1z_ymm, TupleType.Quarter_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.ZMM0, Code.EVEX_Vpmovsqw_xmmm128_k1z_zmm, TupleType.Quarter_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsxdq_xmm_k1z_xmmm64, TupleType.Half_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovsxdq_ymm_k1z_xmmm128, TupleType.Half_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.YMM0, Code.EVEX_Vpmovsxdq_zmm_k1z_ymmm256, TupleType.Half_Mem_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovsqd_xmmm64_k1z_xmm, TupleType.Half_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovsqd_xmmm128_k1z_ymm, TupleType.Half_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Register.ZMM0, Code.EVEX_Vpmovsqd_ymmm256_k1z_zmm, TupleType.Half_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vptestmb_k_k1_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vptestmb_k_k1_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vptestmb_k_k1_zmm_zmmm512, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vptestmw_k_k1_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vptestmw_k_k1_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vptestmw_k_k1_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vptestnmb_k_k1_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vptestnmb_k_k1_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vptestnmb_k_k1_zmm_zmmm512, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vptestnmw_k_k1_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vptestnmw_k_k1_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vptestnmw_k_k1_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vptestmd_k_k1_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vptestmd_k_k1_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vptestmd_k_k1_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vptestmq_k_k1_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vptestmq_k_k1_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vptestmq_k_k1_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vptestnmd_k_k1_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vptestnmd_k_k1_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vptestnmd_k_k1_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vptestnmq_k_k1_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vptestnmq_k_k1_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vptestnmq_k_k1_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid
				),

				// 28
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmuldq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmuldq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmuldq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VK(Register.XMM0, Code.EVEX_Vpmovm2b_xmm_k),
							new OpCodeHandler_EVEX_VK(Register.YMM0, Code.EVEX_Vpmovm2b_ymm_k),
							new OpCodeHandler_EVEX_VK(Register.ZMM0, Code.EVEX_Vpmovm2b_zmm_k)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VK(Register.XMM0, Code.EVEX_Vpmovm2w_xmm_k),
							new OpCodeHandler_EVEX_VK(Register.YMM0, Code.EVEX_Vpmovm2w_ymm_k),
							new OpCodeHandler_EVEX_VK(Register.ZMM0, Code.EVEX_Vpmovm2w_zmm_k)
						)
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vpcmpeqq_k_k1_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vpcmpeqq_k_k1_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vpcmpeqq_k_k1_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KR(Register.XMM0, Code.EVEX_Vpmovb2m_k_xmm),
							new OpCodeHandler_EVEX_KR(Register.YMM0, Code.EVEX_Vpmovb2m_k_ymm),
							new OpCodeHandler_EVEX_KR(Register.ZMM0, Code.EVEX_Vpmovb2m_k_zmm)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KR(Register.XMM0, Code.EVEX_Vpmovw2m_k_xmm),
							new OpCodeHandler_EVEX_KR(Register.YMM0, Code.EVEX_Vpmovw2m_k_ymm),
							new OpCodeHandler_EVEX_KR(Register.ZMM0, Code.EVEX_Vpmovw2m_k_zmm)
						)
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VM(Register.XMM0, Code.EVEX_Vmovntdqa_xmm_m128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VM(Register.YMM0, Code.EVEX_Vmovntdqa_ymm_m256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VM(Register.ZMM0, Code.EVEX_Vmovntdqa_zmm_m512, TupleType.Full_Mem_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VK(Register.XMM0, Code.EVEX_Vpbroadcastmb2q_xmm_k),
							new OpCodeHandler_EVEX_VK(Register.YMM0, Code.EVEX_Vpbroadcastmb2q_ymm_k),
							new OpCodeHandler_EVEX_VK(Register.ZMM0, Code.EVEX_Vpbroadcastmb2q_zmm_k)
						)
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpackusdw_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpackusdw_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpackusdw_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vscalefps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vscalefps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vscalefps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vscalefpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vscalefpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vscalefpd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vscalefss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vscalefsd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,

				// 30
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovzxbw_xmm_k1z_xmmm64, TupleType.Half_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovzxbw_ymm_k1z_xmmm128, TupleType.Half_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.YMM0, Code.EVEX_Vpmovzxbw_zmm_k1z_ymmm256, TupleType.Half_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovwb_xmmm64_k1z_xmm, TupleType.Half_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovwb_xmmm128_k1z_ymm, TupleType.Half_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Register.ZMM0, Code.EVEX_Vpmovwb_ymmm256_k1z_zmm, TupleType.Half_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovzxbd_xmm_k1z_xmmm32, TupleType.Quarter_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovzxbd_ymm_k1z_xmmm64, TupleType.Quarter_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vpmovzxbd_zmm_k1z_xmmm128, TupleType.Quarter_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovdb_xmmm32_k1z_xmm, TupleType.Quarter_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovdb_xmmm64_k1z_ymm, TupleType.Quarter_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.ZMM0, Code.EVEX_Vpmovdb_xmmm128_k1z_zmm, TupleType.Quarter_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovzxbq_xmm_k1z_xmmm16, TupleType.Eighth_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovzxbq_ymm_k1z_xmmm32, TupleType.Eighth_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vpmovzxbq_zmm_k1z_xmmm64, TupleType.Eighth_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovqb_xmmm16_k1z_xmm, TupleType.Eighth_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovqb_xmmm32_k1z_ymm, TupleType.Eighth_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.ZMM0, Code.EVEX_Vpmovqb_xmmm64_k1z_zmm, TupleType.Eighth_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovzxwd_xmm_k1z_xmmm64, TupleType.Half_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovzxwd_ymm_k1z_xmmm128, TupleType.Half_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.YMM0, Code.EVEX_Vpmovzxwd_zmm_k1z_ymmm256, TupleType.Half_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovdw_xmmm64_k1z_xmm, TupleType.Half_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovdw_xmmm128_k1z_ymm, TupleType.Half_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Register.ZMM0, Code.EVEX_Vpmovdw_ymmm256_k1z_zmm, TupleType.Half_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovzxwq_xmm_k1z_xmmm32, TupleType.Quarter_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovzxwq_ymm_k1z_xmmm64, TupleType.Quarter_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vpmovzxwq_zmm_k1z_xmmm128, TupleType.Quarter_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovqw_xmmm32_k1z_xmm, TupleType.Quarter_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovqw_xmmm64_k1z_ymm, TupleType.Quarter_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.ZMM0, Code.EVEX_Vpmovqw_xmmm128_k1z_zmm, TupleType.Quarter_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovzxdq_xmm_k1z_xmmm64, TupleType.Half_Mem_128),
						new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpmovzxdq_ymm_k1z_xmmm128, TupleType.Half_Mem_256),
						new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.YMM0, Code.EVEX_Vpmovzxdq_zmm_k1z_ymmm256, TupleType.Half_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.XMM0, Code.EVEX_Vpmovqd_xmmm64_k1z_xmm, TupleType.Half_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Register.YMM0, Code.EVEX_Vpmovqd_xmmm128_k1z_ymm, TupleType.Half_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Register.ZMM0, Code.EVEX_Vpmovqd_ymmm256_k1z_zmm, TupleType.Half_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vpcmpgtq_k_k1_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vpcmpgtq_k_k1_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vpcmpgtq_k_k1_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// 38
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpminsb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpminsb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpminsb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VK(Register.XMM0, Code.EVEX_Vpmovm2d_xmm_k),
							new OpCodeHandler_EVEX_VK(Register.YMM0, Code.EVEX_Vpmovm2d_ymm_k),
							new OpCodeHandler_EVEX_VK(Register.ZMM0, Code.EVEX_Vpmovm2d_zmm_k)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VK(Register.XMM0, Code.EVEX_Vpmovm2q_xmm_k),
							new OpCodeHandler_EVEX_VK(Register.YMM0, Code.EVEX_Vpmovm2q_ymm_k),
							new OpCodeHandler_EVEX_VK(Register.ZMM0, Code.EVEX_Vpmovm2q_zmm_k)
						)
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpminsd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpminsd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpminsd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpminsq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpminsq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpminsq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KR(Register.XMM0, Code.EVEX_Vpmovd2m_k_xmm),
							new OpCodeHandler_EVEX_KR(Register.YMM0, Code.EVEX_Vpmovd2m_k_ymm),
							new OpCodeHandler_EVEX_KR(Register.ZMM0, Code.EVEX_Vpmovd2m_k_zmm)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KR(Register.XMM0, Code.EVEX_Vpmovq2m_k_xmm),
							new OpCodeHandler_EVEX_KR(Register.YMM0, Code.EVEX_Vpmovq2m_k_ymm),
							new OpCodeHandler_EVEX_KR(Register.ZMM0, Code.EVEX_Vpmovq2m_k_zmm)
						)
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpminuw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpminuw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpminuw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VK(Register.XMM0, Code.EVEX_Vpbroadcastmw2d_xmm_k),
							new OpCodeHandler_EVEX_VK(Register.YMM0, Code.EVEX_Vpbroadcastmw2d_ymm_k),
							new OpCodeHandler_EVEX_VK(Register.ZMM0, Code.EVEX_Vpbroadcastmw2d_zmm_k)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpminud_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpminud_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpminud_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpminuq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpminuq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpminuq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmaxsb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmaxsb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmaxsb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmaxsd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmaxsd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmaxsd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmaxsq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmaxsq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmaxsq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmaxuw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmaxuw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmaxuw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmaxud_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmaxud_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmaxud_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmaxuq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmaxuq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmaxuq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// 40
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmulld_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmulld_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmulld_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmullq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmullq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmullq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Code.EVEX_Vgetexpps_xmm_k1z_xmmm128b32, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Code.EVEX_Vgetexpps_ymm_k1z_ymmm256b32, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vgetexpps_zmm_k1z_zmmm512b32_sae, TupleType.Full_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Code.EVEX_Vgetexppd_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Code.EVEX_Vgetexppd_ymm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vgetexppd_zmm_k1z_zmmm512b64_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vgetexpss_xmm_k1z_xmm_xmmm32_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vgetexpsd_xmm_k1z_xmm_xmmm64_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vplzcntd_xmm_k1z_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vplzcntd_ymm_k1z_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vplzcntd_zmm_k1z_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vplzcntq_xmm_k1z_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vplzcntq_ymm_k1z_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vplzcntq_zmm_k1z_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsrlvd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsrlvd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsrlvd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsrlvq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsrlvq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsrlvq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsravd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsravd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsravd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsravq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsravq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsravq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsllvd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsllvd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsllvd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsllvq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsllvq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsllvq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// 48
				invalid,
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vrcp14ps_xmm_k1z_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vrcp14ps_ymm_k1z_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vrcp14ps_zmm_k1z_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vrcp14pd_xmm_k1z_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vrcp14pd_ymm_k1z_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vrcp14pd_zmm_k1z_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vrcp14ss_xmm_k1z_xmm_xmmm32, TupleType.Tuple1_Scalar),
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vrcp14sd_xmm_k1z_xmm_xmmm64, TupleType.Tuple1_Scalar)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vrsqrt14ps_xmm_k1z_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vrsqrt14ps_ymm_k1z_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vrsqrt14ps_zmm_k1z_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vrsqrt14pd_xmm_k1z_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vrsqrt14pd_ymm_k1z_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vrsqrt14pd_zmm_k1z_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vrsqrt14ss_xmm_k1z_xmm_xmmm32, TupleType.Tuple1_Scalar),
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vrsqrt14sd_xmm_k1z_xmm_xmmm64, TupleType.Tuple1_Scalar)
					),
					invalid,
					invalid
				),

				// 50
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpdpbusd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpdpbusd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpdpbusd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpdpbusds_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpdpbusds_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpdpbusds_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpdpwssd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpdpwssd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpdpwssd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vdpbf16ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vdpbf16ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vdpbf16ps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHM(Register.ZMM0, Code.EVEX_Vp4dpwssd_zmm_k1z_zmmp3_m128, TupleType.Tuple1_4X),
						invalid
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpdpwssds_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpdpwssds_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpdpwssds_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHM(Register.ZMM0, Code.EVEX_Vp4dpwssds_zmm_k1z_zmmp3_m128, TupleType.Tuple1_4X),
						invalid
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpopcntb_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpopcntb_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpopcntb_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpopcntw_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpopcntw_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpopcntw_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpopcntd_xmm_k1z_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpopcntd_ymm_k1z_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpopcntd_zmm_k1z_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpopcntq_xmm_k1z_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpopcntq_ymm_k1z_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpopcntq_zmm_k1z_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,

				// 58
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpbroadcastd_xmm_k1z_xmmm32, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpbroadcastd_ymm_k1z_xmmm32, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vpbroadcastd_zmm_k1z_xmmm32, TupleType.Tuple1_Scalar)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vbroadcasti32x2_xmm_k1z_xmmm64, TupleType.Tuple2),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vbroadcasti32x2_ymm_k1z_xmmm64, TupleType.Tuple2),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vbroadcasti32x2_zmm_k1z_xmmm64, TupleType.Tuple2)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpbroadcastq_xmm_k1z_xmmm64, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpbroadcastq_ymm_k1z_xmmm64, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vpbroadcastq_zmm_k1z_xmmm64, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkM(Register.YMM0, Code.EVEX_Vbroadcasti32x4_ymm_k1z_m128, TupleType.Tuple4),
							new OpCodeHandler_EVEX_VkM(Register.ZMM0, Code.EVEX_Vbroadcasti32x4_zmm_k1z_m128, TupleType.Tuple4)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkM(Register.YMM0, Code.EVEX_Vbroadcasti64x2_ymm_k1z_m128, TupleType.Tuple2),
							new OpCodeHandler_EVEX_VkM(Register.ZMM0, Code.EVEX_Vbroadcasti64x2_zmm_k1z_m128, TupleType.Tuple2)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkM(Register.ZMM0, Code.EVEX_Vbroadcasti32x8_zmm_k1z_m256, TupleType.Tuple8)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkM(Register.ZMM0, Code.EVEX_Vbroadcasti64x4_zmm_k1z_m256, TupleType.Tuple4)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				invalid,
				invalid,

				// 60
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpexpandb_xmm_k1z_xmmm128, TupleType.Tuple1_Scalar_1),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpexpandb_ymm_k1z_ymmm256, TupleType.Tuple1_Scalar_1),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpexpandb_zmm_k1z_zmmm512, TupleType.Tuple1_Scalar_1)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpexpandw_xmm_k1z_xmmm128, TupleType.Tuple1_Scalar_2),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpexpandw_ymm_k1z_ymmm256, TupleType.Tuple1_Scalar_2),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpexpandw_zmm_k1z_zmmm512, TupleType.Tuple1_Scalar_2)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vpcompressb_xmmm128_k1z_xmm, TupleType.Tuple1_Scalar_1),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vpcompressb_ymmm256_k1z_ymm, TupleType.Tuple1_Scalar_1),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vpcompressb_zmmm512_k1z_zmm, TupleType.Tuple1_Scalar_1)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vpcompressw_xmmm128_k1z_xmm, TupleType.Tuple1_Scalar_2),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vpcompressw_ymmm256_k1z_ymm, TupleType.Tuple1_Scalar_2),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vpcompressw_zmmm512_k1z_zmm, TupleType.Tuple1_Scalar_2)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpblendmd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpblendmd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpblendmd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpblendmq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpblendmq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpblendmq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vblendmps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vblendmps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vblendmps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vblendmpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vblendmpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vblendmpd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpblendmb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpblendmb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpblendmb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpblendmw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpblendmw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpblendmw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				invalid,

				// 68
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					invalid,
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KP1HW(Register.XMM0, Code.EVEX_Vp2intersectd_k_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_KP1HW(Register.YMM0, Code.EVEX_Vp2intersectd_k_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_KP1HW(Register.ZMM0, Code.EVEX_Vp2intersectd_k_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KP1HW(Register.XMM0, Code.EVEX_Vp2intersectq_k_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_KP1HW(Register.YMM0, Code.EVEX_Vp2intersectq_k_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_KP1HW(Register.ZMM0, Code.EVEX_Vp2intersectq_k_zmm_zmmm512b64, TupleType.Full_512)
						)
					)
				),
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 70
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpshldvw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpshldvw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpshldvw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpshldvd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpshldvd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpshldvd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpshldvq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpshldvq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpshldvq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpshrdvw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpshrdvw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpshrdvw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtneps2bf16_xmm_k1z_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.YMM0, Code.EVEX_Vcvtneps2bf16_xmm_k1z_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.ZMM0, Code.EVEX_Vcvtneps2bf16_ymm_k1z_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vcvtne2ps2bf16_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vcvtne2ps2bf16_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vcvtne2ps2bf16_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpshrdvd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpshrdvd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpshrdvd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpshrdvq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpshrdvq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpshrdvq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermi2b_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermi2b_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermi2b_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermi2w_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermi2w_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermi2w_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermi2d_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermi2d_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermi2d_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermi2q_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermi2q_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermi2q_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermi2ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermi2ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermi2ps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermi2pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermi2pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermi2pd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// 78
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpbroadcastb_xmm_k1z_xmmm8, TupleType.Tuple1_Scalar_1),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpbroadcastb_ymm_k1z_xmmm8, TupleType.Tuple1_Scalar_1),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vpbroadcastb_zmm_k1z_xmmm8, TupleType.Tuple1_Scalar_1)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vpbroadcastw_xmm_k1z_xmmm16, TupleType.Tuple1_Scalar_2),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vpbroadcastw_ymm_k1z_xmmm16, TupleType.Tuple1_Scalar_2),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.XMM0, Code.EVEX_Vpbroadcastw_zmm_k1z_xmmm16, TupleType.Tuple1_Scalar_2)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkEv_REXW(Register.XMM0, Code.EVEX_Vpbroadcastb_xmm_k1z_r32),
						new OpCodeHandler_EVEX_VkEv_REXW(Register.YMM0, Code.EVEX_Vpbroadcastb_ymm_k1z_r32),
						new OpCodeHandler_EVEX_VkEv_REXW(Register.ZMM0, Code.EVEX_Vpbroadcastb_zmm_k1z_r32)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkEv_REXW(Register.XMM0, Code.EVEX_Vpbroadcastw_xmm_k1z_r32),
						new OpCodeHandler_EVEX_VkEv_REXW(Register.YMM0, Code.EVEX_Vpbroadcastw_ymm_k1z_r32),
						new OpCodeHandler_EVEX_VkEv_REXW(Register.ZMM0, Code.EVEX_Vpbroadcastw_zmm_k1z_r32)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkEv_REXW(Register.XMM0, Code.EVEX_Vpbroadcastd_xmm_k1z_r32, Code.EVEX_Vpbroadcastq_xmm_k1z_r64),
						new OpCodeHandler_EVEX_VkEv_REXW(Register.YMM0, Code.EVEX_Vpbroadcastd_ymm_k1z_r32, Code.EVEX_Vpbroadcastq_ymm_k1z_r64),
						new OpCodeHandler_EVEX_VkEv_REXW(Register.ZMM0, Code.EVEX_Vpbroadcastd_zmm_k1z_r32, Code.EVEX_Vpbroadcastq_zmm_k1z_r64)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermt2b_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermt2b_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermt2b_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermt2w_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermt2w_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermt2w_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermt2d_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermt2d_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermt2d_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermt2q_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermt2q_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermt2q_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermt2ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermt2ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermt2ps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermt2pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermt2pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermt2pd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// 80
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmultishiftqb_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmultishiftqb_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmultishiftqb_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				invalid,
				invalid,

				// 88
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vexpandps_xmm_k1z_xmmm128, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vexpandps_ymm_k1z_ymmm256, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vexpandps_zmm_k1z_zmmm512, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vexpandpd_xmm_k1z_xmmm128, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vexpandpd_ymm_k1z_ymmm256, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vexpandpd_zmm_k1z_zmmm512, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpexpandd_xmm_k1z_xmmm128, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpexpandd_ymm_k1z_ymmm256, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpexpandd_zmm_k1z_zmmm512, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpexpandq_xmm_k1z_xmmm128, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpexpandq_ymm_k1z_ymmm256, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpexpandq_zmm_k1z_zmmm512, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vcompressps_xmmm128_k1z_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vcompressps_ymmm256_k1z_ymm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vcompressps_zmmm512_k1z_zmm, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vcompresspd_xmmm128_k1z_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vcompresspd_ymmm256_k1z_ymm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vcompresspd_zmmm512_k1z_zmm, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vpcompressd_xmmm128_k1z_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vpcompressd_ymmm256_k1z_ymm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vpcompressd_zmmm512_k1z_zmm, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vpcompressq_xmmm128_k1z_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vpcompressq_ymmm256_k1z_ymm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vpcompressq_zmmm512_k1z_zmm, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpermw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpermw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpermw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vpshufbitqmb_k_k1_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vpshufbitqmb_k_k1_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vpshufbitqmb_k_k1_zmm_zmmm512, TupleType.Full_Mem_512)
						),
						invalid
					),
					invalid,
					invalid
				),

				// 90
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_Vk_VSIB(Register.XMM0, Register.XMM0, Code.EVEX_Vpgatherdd_xmm_k1_vm32x, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.YMM0, Register.YMM0, Code.EVEX_Vpgatherdd_ymm_k1_vm32y, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.ZMM0, Register.ZMM0, Code.EVEX_Vpgatherdd_zmm_k1_vm32z, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_Vk_VSIB(Register.XMM0, Register.XMM0, Code.EVEX_Vpgatherdq_xmm_k1_vm32x, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.YMM0, Register.XMM0, Code.EVEX_Vpgatherdq_ymm_k1_vm32x, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.ZMM0, Register.YMM0, Code.EVEX_Vpgatherdq_zmm_k1_vm32y, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_Vk_VSIB(Register.XMM0, Register.XMM0, Code.EVEX_Vpgatherqd_xmm_k1_vm64x, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.XMM0, Register.YMM0, Code.EVEX_Vpgatherqd_xmm_k1_vm64y, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.YMM0, Register.ZMM0, Code.EVEX_Vpgatherqd_ymm_k1_vm64z, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_Vk_VSIB(Register.XMM0, Register.XMM0, Code.EVEX_Vpgatherqq_xmm_k1_vm64x, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.YMM0, Register.YMM0, Code.EVEX_Vpgatherqq_ymm_k1_vm64y, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.ZMM0, Register.ZMM0, Code.EVEX_Vpgatherqq_zmm_k1_vm64z, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_Vk_VSIB(Register.XMM0, Register.XMM0, Code.EVEX_Vgatherdps_xmm_k1_vm32x, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.YMM0, Register.YMM0, Code.EVEX_Vgatherdps_ymm_k1_vm32y, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.ZMM0, Register.ZMM0, Code.EVEX_Vgatherdps_zmm_k1_vm32z, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_Vk_VSIB(Register.XMM0, Register.XMM0, Code.EVEX_Vgatherdpd_xmm_k1_vm32x, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.YMM0, Register.XMM0, Code.EVEX_Vgatherdpd_ymm_k1_vm32x, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.ZMM0, Register.YMM0, Code.EVEX_Vgatherdpd_zmm_k1_vm32y, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_Vk_VSIB(Register.XMM0, Register.XMM0, Code.EVEX_Vgatherqps_xmm_k1_vm64x, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.XMM0, Register.YMM0, Code.EVEX_Vgatherqps_xmm_k1_vm64y, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.YMM0, Register.ZMM0, Code.EVEX_Vgatherqps_ymm_k1_vm64z, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_Vk_VSIB(Register.XMM0, Register.XMM0, Code.EVEX_Vgatherqpd_xmm_k1_vm64x, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.YMM0, Register.YMM0, Code.EVEX_Vgatherqpd_ymm_k1_vm64y, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_Vk_VSIB(Register.ZMM0, Register.ZMM0, Code.EVEX_Vgatherqpd_zmm_k1_vm64z, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmaddsub132ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmaddsub132ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmaddsub132ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmaddsub132pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmaddsub132pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmaddsub132pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsubadd132ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsubadd132ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsubadd132ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsubadd132pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsubadd132pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsubadd132pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),

				// 98
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd132ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmadd132ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmadd132ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd132pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmadd132pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmadd132pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd132ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd132sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub132ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsub132ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsub132ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub132pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsub132pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsub132pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHM(Register.ZMM0, Code.EVEX_V4fmaddps_zmm_k1z_zmmp3_m128, TupleType.Tuple1_4X),
						invalid
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub132ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub132sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHM(Register.XMM0, Code.EVEX_V4fmaddss_xmm_k1z_xmmp3_m128, TupleType.Tuple1_4X),
						invalid
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd132ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmadd132ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmadd132ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd132pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmadd132pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmadd132pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd132ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd132sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub132ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmsub132ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmsub132ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub132pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmsub132pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmsub132pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub132ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub132sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),

				// A0
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.XMM0, Register.XMM0, Code.EVEX_Vpscatterdd_vm32x_k1_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.YMM0, Register.YMM0, Code.EVEX_Vpscatterdd_vm32y_k1_ymm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.ZMM0, Register.ZMM0, Code.EVEX_Vpscatterdd_vm32z_k1_zmm, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.XMM0, Register.XMM0, Code.EVEX_Vpscatterdq_vm32x_k1_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.XMM0, Register.YMM0, Code.EVEX_Vpscatterdq_vm32x_k1_ymm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.YMM0, Register.ZMM0, Code.EVEX_Vpscatterdq_vm32y_k1_zmm, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.XMM0, Register.XMM0, Code.EVEX_Vpscatterqd_vm64x_k1_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.YMM0, Register.XMM0, Code.EVEX_Vpscatterqd_vm64y_k1_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.ZMM0, Register.YMM0, Code.EVEX_Vpscatterqd_vm64z_k1_ymm, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.XMM0, Register.XMM0, Code.EVEX_Vpscatterqq_vm64x_k1_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.YMM0, Register.YMM0, Code.EVEX_Vpscatterqq_vm64y_k1_ymm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.ZMM0, Register.ZMM0, Code.EVEX_Vpscatterqq_vm64z_k1_zmm, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.XMM0, Register.XMM0, Code.EVEX_Vscatterdps_vm32x_k1_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.YMM0, Register.YMM0, Code.EVEX_Vscatterdps_vm32y_k1_ymm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.ZMM0, Register.ZMM0, Code.EVEX_Vscatterdps_vm32z_k1_zmm, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.XMM0, Register.XMM0, Code.EVEX_Vscatterdpd_vm32x_k1_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.XMM0, Register.YMM0, Code.EVEX_Vscatterdpd_vm32x_k1_ymm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.YMM0, Register.ZMM0, Code.EVEX_Vscatterdpd_vm32y_k1_zmm, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.XMM0, Register.XMM0, Code.EVEX_Vscatterqps_vm64x_k1_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.YMM0, Register.XMM0, Code.EVEX_Vscatterqps_vm64y_k1_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.ZMM0, Register.YMM0, Code.EVEX_Vscatterqps_vm64z_k1_ymm, TupleType.Tuple1_Scalar)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.XMM0, Register.XMM0, Code.EVEX_Vscatterqpd_vm64x_k1_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.YMM0, Register.YMM0, Code.EVEX_Vscatterqpd_vm64y_k1_ymm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VSIB_k1_VX(Register.ZMM0, Register.ZMM0, Code.EVEX_Vscatterqpd_vm64z_k1_zmm, TupleType.Tuple1_Scalar)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),

				// A8
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd213ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmadd213ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmadd213ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd213pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmadd213pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmadd213pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd213ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd213sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub213ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsub213ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsub213ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub213pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsub213pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsub213pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHM(Register.ZMM0, Code.EVEX_V4fnmaddps_zmm_k1z_zmmp3_m128, TupleType.Tuple1_4X),
						invalid
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub213ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub213sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHM(Register.XMM0, Code.EVEX_V4fnmaddss_xmm_k1z_xmmp3_m128, TupleType.Tuple1_4X),
						invalid
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd213ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmadd213ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmadd213ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd213pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmadd213pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmadd213pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd213ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd213sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub213ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmsub213ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmsub213ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub213pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmsub213pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmsub213pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub213ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub213sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),

				// B0
				invalid,
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmadd52luq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmadd52luq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmadd52luq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmadd52huq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmadd52huq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmadd52huq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmaddsub231ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmaddsub231ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmaddsub231ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmaddsub231pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmaddsub231pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmaddsub231pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsubadd231ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsubadd231ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsubadd231ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsubadd231pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsubadd231pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsubadd231pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),

				// B8
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd231ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmadd231ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmadd231ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd231pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmadd231pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmadd231pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd231ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmadd231sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub231ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsub231ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsub231ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub231pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfmsub231pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfmsub231pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub231ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfmsub231sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd231ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmadd231ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmadd231ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd231pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmadd231pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmadd231pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd231ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmadd231sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub231ps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmsub231ps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmsub231ps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub231pd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vfnmsub231pd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vfnmsub231pd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub231ss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vfnmsub231sd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					),
					invalid,
					invalid
				),

				// C0
				invalid,
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpconflictd_xmm_k1z_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpconflictd_ymm_k1z_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpconflictd_zmm_k1z_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vpconflictq_xmm_k1z_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vpconflictq_ymm_k1z_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vpconflictq_zmm_k1z_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_Group(handlers_Grp_0F38C6),
				new OpCodeHandler_Group(handlers_Grp_0F38C7),

				// C8
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vexp2ps_zmm_k1z_zmmm512b32_sae, TupleType.Full_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vexp2pd_zmm_k1z_zmmm512b64_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vrcp28ps_zmm_k1z_zmmm512b32_sae, TupleType.Full_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vrcp28pd_zmm_k1z_zmmm512b64_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vrcp28ss_xmm_k1z_xmm_xmmm32_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vrcp28sd_xmm_k1z_xmm_xmmm64_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vrsqrt28ps_zmm_k1z_zmmm512b32_sae, TupleType.Full_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vrsqrt28pd_zmm_k1z_zmmm512b64_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vrsqrt28ss_xmm_k1z_xmm_xmmm32_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vrsqrt28sd_xmm_k1z_xmm_xmmm64_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vgf2p8mulb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vgf2p8mulb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vgf2p8mulb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
						),
						invalid
					),
					invalid,
					invalid
				),

				// D0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// D8
				invalid,
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VHW(Register.XMM0, Code.EVEX_Vaesenc_xmm_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VHW(Register.YMM0, Code.EVEX_Vaesenc_ymm_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VHW(Register.ZMM0, Code.EVEX_Vaesenc_zmm_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VHW(Register.XMM0, Code.EVEX_Vaesenclast_xmm_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VHW(Register.YMM0, Code.EVEX_Vaesenclast_ymm_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VHW(Register.ZMM0, Code.EVEX_Vaesenclast_zmm_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VHW(Register.XMM0, Code.EVEX_Vaesdec_xmm_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VHW(Register.YMM0, Code.EVEX_Vaesdec_ymm_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VHW(Register.ZMM0, Code.EVEX_Vaesdec_zmm_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VHW(Register.XMM0, Code.EVEX_Vaesdeclast_xmm_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VHW(Register.YMM0, Code.EVEX_Vaesdeclast_ymm_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VHW(Register.ZMM0, Code.EVEX_Vaesdeclast_zmm_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),

				// E0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// E8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// F0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// F8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
			};

			ThreeByteHandlers_0F3AXX = new OpCodeHandler[0x100] {
				// 00
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkWIb(Register.YMM0, Code.EVEX_Vpermq_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkWIb(Register.ZMM0, Code.EVEX_Vpermq_zmm_k1z_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkWIb(Register.YMM0, Code.EVEX_Vpermpd_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkWIb(Register.ZMM0, Code.EVEX_Vpermpd_zmm_k1z_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Valignd_xmm_k1z_xmm_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Valignd_ymm_k1z_ymm_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Valignd_zmm_k1z_zmm_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Valignq_xmm_k1z_xmm_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Valignq_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Valignq_zmm_k1z_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkWIb(Register.XMM0, Code.EVEX_Vpermilps_xmm_k1z_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkWIb(Register.YMM0, Code.EVEX_Vpermilps_ymm_k1z_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkWIb(Register.ZMM0, Code.EVEX_Vpermilps_zmm_k1z_zmmm512b32_imm8, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkWIb(Register.XMM0, Code.EVEX_Vpermilpd_xmm_k1z_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkWIb(Register.YMM0, Code.EVEX_Vpermilpd_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkWIb(Register.ZMM0, Code.EVEX_Vpermilpd_zmm_k1z_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,

				// 08
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkWIb_er(Register.XMM0, Code.EVEX_Vrndscaleps_xmm_k1z_xmmm128b32_imm8, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.YMM0, Code.EVEX_Vrndscaleps_ymm_k1z_ymmm256b32_imm8, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.ZMM0, Code.EVEX_Vrndscaleps_zmm_k1z_zmmm512b32_imm8_sae, TupleType.Full_512, onlySAE: true)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkWIb_er(Register.XMM0, Code.EVEX_Vrndscalepd_xmm_k1z_xmmm128b64_imm8, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.YMM0, Code.EVEX_Vrndscalepd_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.ZMM0, Code.EVEX_Vrndscalepd_zmm_k1z_zmmm512b64_imm8_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vrndscaless_xmm_k1z_xmm_xmmm32_imm8_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vrndscalesd_xmm_k1z_xmm_xmmm64_imm8_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vpalignr_xmm_k1z_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vpalignr_ymm_k1z_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vpalignr_zmm_k1z_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),

				// 10
				invalid,
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_GvM_VX_Ib(Register.XMM0, Code.EVEX_Vpextrb_r32m8_xmm_imm8, Code.EVEX_Vpextrb_r64m8_xmm_imm8, TupleType.Tuple1_Scalar_1, TupleType.Tuple1_Scalar_1),
						invalid,
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_GvM_VX_Ib(Register.XMM0, Code.EVEX_Vpextrw_r32m16_xmm_imm8, Code.EVEX_Vpextrw_r64m16_xmm_imm8, TupleType.Tuple1_Scalar_2, TupleType.Tuple1_Scalar_2),
						invalid,
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_GvM_VX_Ib(Register.XMM0, Code.EVEX_Vpextrd_rm32_xmm_imm8, Code.EVEX_Vpextrq_rm64_xmm_imm8, TupleType.Tuple1_Scalar_4, TupleType.Tuple1_Scalar_8),
						invalid,
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_Ed_V_Ib(Register.XMM0, Code.EVEX_Vextractps_rm32_xmm_imm8, Code.EVEX_Vextractps_rm64_xmm_imm8, TupleType.Tuple1_Scalar_4, TupleType.Tuple1_Scalar_4),
						invalid,
						invalid
					),
					invalid,
					invalid
				),

				// 18
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vinsertf32x4_ymm_k1z_ymm_xmmm128_imm8, TupleType.Tuple4),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vinsertf32x4_zmm_k1z_zmm_xmmm128_imm8, TupleType.Tuple4)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vinsertf64x2_ymm_k1z_ymm_xmmm128_imm8, TupleType.Tuple2),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vinsertf64x2_zmm_k1z_zmm_xmmm128_imm8, TupleType.Tuple2)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_WkVIb(Register.XMM0, Register.YMM0, Code.EVEX_Vextractf32x4_xmmm128_k1z_ymm_imm8, TupleType.Tuple4),
							new OpCodeHandler_EVEX_WkVIb(Register.XMM0, Register.ZMM0, Code.EVEX_Vextractf32x4_xmmm128_k1z_zmm_imm8, TupleType.Tuple4)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_WkVIb(Register.XMM0, Register.YMM0, Code.EVEX_Vextractf64x2_xmmm128_k1z_ymm_imm8, TupleType.Tuple2),
							new OpCodeHandler_EVEX_WkVIb(Register.XMM0, Register.ZMM0, Code.EVEX_Vextractf64x2_xmmm128_k1z_zmm_imm8, TupleType.Tuple2)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Register.ZMM0, Register.YMM0, Code.EVEX_Vinsertf32x8_zmm_k1z_zmm_ymmm256_imm8, TupleType.Tuple8)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Register.ZMM0, Register.YMM0, Code.EVEX_Vinsertf64x4_zmm_k1z_zmm_ymmm256_imm8, TupleType.Tuple4)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_WkVIb(Register.YMM0, Register.ZMM0, Code.EVEX_Vextractf32x8_ymmm256_k1z_zmm_imm8, TupleType.Tuple8)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_WkVIb(Register.YMM0, Register.ZMM0, Code.EVEX_Vextractf64x4_ymmm256_k1z_zmm_imm8, TupleType.Tuple4)
						)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_WkVIb_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtps2ph_xmmm64_k1z_xmm_imm8, TupleType.Half_Mem_128, onlySAE: true),
							new OpCodeHandler_EVEX_WkVIb_er(Register.XMM0, Register.YMM0, Code.EVEX_Vcvtps2ph_xmmm128_k1z_ymm_imm8, TupleType.Half_Mem_256, onlySAE: true),
							new OpCodeHandler_EVEX_WkVIb_er(Register.YMM0, Register.ZMM0, Code.EVEX_Vcvtps2ph_ymmm256_k1z_zmm_imm8_sae, TupleType.Half_Mem_512, onlySAE: true)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHWIb(Register.XMM0, Code.EVEX_Vpcmpud_k_k1_xmm_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHWIb(Register.YMM0, Code.EVEX_Vpcmpud_k_k1_ymm_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHWIb(Register.ZMM0, Code.EVEX_Vpcmpud_k_k1_zmm_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHWIb(Register.XMM0, Code.EVEX_Vpcmpuq_k_k1_xmm_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHWIb(Register.YMM0, Code.EVEX_Vpcmpuq_k_k1_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHWIb(Register.ZMM0, Code.EVEX_Vpcmpuq_k_k1_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHWIb(Register.XMM0, Code.EVEX_Vpcmpd_k_k1_xmm_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHWIb(Register.YMM0, Code.EVEX_Vpcmpd_k_k1_ymm_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHWIb(Register.ZMM0, Code.EVEX_Vpcmpd_k_k1_zmm_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHWIb(Register.XMM0, Code.EVEX_Vpcmpq_k_k1_xmm_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHWIb(Register.YMM0, Code.EVEX_Vpcmpq_k_k1_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHWIb(Register.ZMM0, Code.EVEX_Vpcmpq_k_k1_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// 20
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_V_H_Ev_Ib(Register.XMM0, Code.EVEX_Vpinsrb_xmm_xmm_r32m8_imm8, Code.EVEX_Vpinsrb_xmm_xmm_r64m8_imm8, TupleType.Tuple1_Scalar_1, TupleType.Tuple1_Scalar_1),
						invalid,
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VHWIb(Register.XMM0, Code.EVEX_Vinsertps_xmm_xmm_xmmm32_imm8, TupleType.Tuple1_Scalar),
							invalid,
							invalid
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_V_H_Ev_Ib(Register.XMM0, Code.EVEX_Vpinsrd_xmm_xmm_rm32_imm8, Code.EVEX_Vpinsrq_xmm_xmm_rm64_imm8, TupleType.Tuple1_Scalar_4, TupleType.Tuple1_Scalar_8),
						invalid,
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vshuff32x4_ymm_k1z_ymm_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vshuff32x4_zmm_k1z_zmm_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vshuff64x2_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vshuff64x2_zmm_k1z_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vpternlogd_xmm_k1z_xmm_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vpternlogd_ymm_k1z_ymm_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vpternlogd_zmm_k1z_zmm_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vpternlogq_xmm_k1z_xmm_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vpternlogq_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vpternlogq_zmm_k1z_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkWIb_er(Register.XMM0, Code.EVEX_Vgetmantps_xmm_k1z_xmmm128b32_imm8, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.YMM0, Code.EVEX_Vgetmantps_ymm_k1z_ymmm256b32_imm8, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.ZMM0, Code.EVEX_Vgetmantps_zmm_k1z_zmmm512b32_imm8_sae, TupleType.Full_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkWIb_er(Register.XMM0, Code.EVEX_Vgetmantpd_xmm_k1z_xmmm128b64_imm8, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.YMM0, Code.EVEX_Vgetmantpd_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.ZMM0, Code.EVEX_Vgetmantpd_zmm_k1z_zmmm512b64_imm8_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vgetmantss_xmm_k1z_xmm_xmmm32_imm8_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vgetmantsd_xmm_k1z_xmm_xmmm64_imm8_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					),
					invalid,
					invalid
				),

				// 28
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 30
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 38
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vinserti32x4_ymm_k1z_ymm_xmmm128_imm8, TupleType.Tuple4),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vinserti32x4_zmm_k1z_zmm_xmmm128_imm8, TupleType.Tuple4)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vinserti64x2_ymm_k1z_ymm_xmmm128_imm8, TupleType.Tuple2),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vinserti64x2_zmm_k1z_zmm_xmmm128_imm8, TupleType.Tuple2)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_WkVIb(Register.XMM0, Register.YMM0, Code.EVEX_Vextracti32x4_xmmm128_k1z_ymm_imm8, TupleType.Tuple4),
							new OpCodeHandler_EVEX_WkVIb(Register.XMM0, Register.ZMM0, Code.EVEX_Vextracti32x4_xmmm128_k1z_zmm_imm8, TupleType.Tuple4)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_WkVIb(Register.XMM0, Register.YMM0, Code.EVEX_Vextracti64x2_xmmm128_k1z_ymm_imm8, TupleType.Tuple2),
							new OpCodeHandler_EVEX_WkVIb(Register.XMM0, Register.ZMM0, Code.EVEX_Vextracti64x2_xmmm128_k1z_zmm_imm8, TupleType.Tuple2)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Register.ZMM0, Register.YMM0, Code.EVEX_Vinserti32x8_zmm_k1z_zmm_ymmm256_imm8, TupleType.Tuple8)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Register.ZMM0, Register.YMM0, Code.EVEX_Vinserti64x4_zmm_k1z_zmm_ymmm256_imm8, TupleType.Tuple4)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_WkVIb(Register.YMM0, Register.ZMM0, Code.EVEX_Vextracti32x8_ymmm256_k1z_zmm_imm8, TupleType.Tuple8)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							invalid,
							new OpCodeHandler_EVEX_WkVIb(Register.YMM0, Register.ZMM0, Code.EVEX_Vextracti64x4_ymmm256_k1z_zmm_imm8, TupleType.Tuple4)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHWIb(Register.XMM0, Code.EVEX_Vpcmpub_k_k1_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_KkHWIb(Register.YMM0, Code.EVEX_Vpcmpub_k_k1_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_KkHWIb(Register.ZMM0, Code.EVEX_Vpcmpub_k_k1_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHWIb(Register.XMM0, Code.EVEX_Vpcmpuw_k_k1_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_KkHWIb(Register.YMM0, Code.EVEX_Vpcmpuw_k_k1_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_KkHWIb(Register.ZMM0, Code.EVEX_Vpcmpuw_k_k1_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHWIb(Register.XMM0, Code.EVEX_Vpcmpb_k_k1_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_KkHWIb(Register.YMM0, Code.EVEX_Vpcmpb_k_k1_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_KkHWIb(Register.ZMM0, Code.EVEX_Vpcmpb_k_k1_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHWIb(Register.XMM0, Code.EVEX_Vpcmpw_k_k1_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_KkHWIb(Register.YMM0, Code.EVEX_Vpcmpw_k_k1_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_KkHWIb(Register.ZMM0, Code.EVEX_Vpcmpw_k_k1_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),

				// 40
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vdbpsadbw_xmm_k1z_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vdbpsadbw_ymm_k1z_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vdbpsadbw_zmm_k1z_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vshufi32x4_ymm_k1z_ymm_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vshufi32x4_zmm_k1z_zmm_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							invalid,
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vshufi64x2_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vshufi64x2_zmm_k1z_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VHWIb(Register.XMM0, Code.EVEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VHWIb(Register.YMM0, Code.EVEX_Vpclmulqdq_ymm_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VHWIb(Register.ZMM0, Code.EVEX_Vpclmulqdq_zmm_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				invalid,

				// 48
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 50
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vrangeps_xmm_k1z_xmm_xmmm128b32_imm8, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkHWIb_er(Register.YMM0, Code.EVEX_Vrangeps_ymm_k1z_ymm_ymmm256b32_imm8, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkHWIb_er(Register.ZMM0, Code.EVEX_Vrangeps_zmm_k1z_zmm_zmmm512b32_imm8_sae, TupleType.Full_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vrangepd_xmm_k1z_xmm_xmmm128b64_imm8, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkHWIb_er(Register.YMM0, Code.EVEX_Vrangepd_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkHWIb_er(Register.ZMM0, Code.EVEX_Vrangepd_zmm_k1z_zmm_zmmm512b64_imm8_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vrangess_xmm_k1z_xmm_xmmm32_imm8_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vrangesd_xmm_k1z_xmm_xmmm64_imm8_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vfixupimmps_xmm_k1z_xmm_xmmm128b32_imm8, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkHWIb_er(Register.YMM0, Code.EVEX_Vfixupimmps_ymm_k1z_ymm_ymmm256b32_imm8, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkHWIb_er(Register.ZMM0, Code.EVEX_Vfixupimmps_zmm_k1z_zmm_zmmm512b32_imm8_sae, TupleType.Full_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vfixupimmpd_xmm_k1z_xmm_xmmm128b64_imm8, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkHWIb_er(Register.YMM0, Code.EVEX_Vfixupimmpd_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkHWIb_er(Register.ZMM0, Code.EVEX_Vfixupimmpd_zmm_k1z_zmm_zmmm512b64_imm8_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vfixupimmss_xmm_k1z_xmm_xmmm32_imm8_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vfixupimmsd_xmm_k1z_xmm_xmmm64_imm8_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkWIb_er(Register.XMM0, Code.EVEX_Vreduceps_xmm_k1z_xmmm128b32_imm8, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.YMM0, Code.EVEX_Vreduceps_ymm_k1z_ymmm256b32_imm8, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.ZMM0, Code.EVEX_Vreduceps_zmm_k1z_zmmm512b32_imm8_sae, TupleType.Full_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkWIb_er(Register.XMM0, Code.EVEX_Vreducepd_xmm_k1z_xmmm128b64_imm8, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.YMM0, Code.EVEX_Vreducepd_ymm_k1z_ymmm256b64_imm8, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkWIb_er(Register.ZMM0, Code.EVEX_Vreducepd_zmm_k1z_zmmm512b64_imm8_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vreducess_xmm_k1z_xmm_xmmm32_imm8_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						new OpCodeHandler_EVEX_VkHWIb_er(Register.XMM0, Code.EVEX_Vreducesd_xmm_k1z_xmm_xmmm64_imm8_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					),
					invalid,
					invalid
				),

				// 58
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 60
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkWIb(Register.XMM0, Code.EVEX_Vfpclassps_k_k1_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkWIb(Register.YMM0, Code.EVEX_Vfpclassps_k_k1_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkWIb(Register.ZMM0, Code.EVEX_Vfpclassps_k_k1_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkWIb(Register.XMM0, Code.EVEX_Vfpclasspd_k_k1_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkWIb(Register.YMM0, Code.EVEX_Vfpclasspd_k_k1_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkWIb(Register.ZMM0, Code.EVEX_Vfpclasspd_k_k1_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_KkWIb(Register.XMM0, Code.EVEX_Vfpclassss_k_k1_xmmm32_imm8, TupleType.Tuple1_Scalar),
						new OpCodeHandler_EVEX_KkWIb(Register.XMM0, Code.EVEX_Vfpclasssd_k_k1_xmmm64_imm8, TupleType.Tuple1_Scalar)
					),
					invalid,
					invalid
				),

				// 68
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 70
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vpshldw_xmm_k1z_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vpshldw_ymm_k1z_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vpshldw_zmm_k1z_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vpshldd_xmm_k1z_xmm_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vpshldd_ymm_k1z_ymm_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vpshldd_zmm_k1z_zmm_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vpshldq_xmm_k1z_xmm_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vpshldq_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vpshldq_zmm_k1z_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vpshrdw_xmm_k1z_xmm_xmmm128_imm8, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vpshrdw_ymm_k1z_ymm_ymmm256_imm8, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vpshrdw_zmm_k1z_zmm_zmmm512_imm8, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vpshrdd_xmm_k1z_xmm_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vpshrdd_ymm_k1z_ymm_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vpshrdd_zmm_k1z_zmm_zmmm512b32_imm8, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vpshrdq_xmm_k1z_xmm_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vpshrdq_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vpshrdq_zmm_k1z_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,
				invalid,
				invalid,
				invalid,

				// 78
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 80
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 88
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 90
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 98
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// A0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// A8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// B0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// B8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// C0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// C8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vgf2p8affineqb_xmm_k1z_xmm_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vgf2p8affineqb_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vgf2p8affineqb_zmm_k1z_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vgf2p8affineinvqb_xmm_k1z_xmm_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vgf2p8affineinvqb_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vgf2p8affineinvqb_zmm_k1z_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// D0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// D8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// E0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// E8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// F0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// F8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
			};

			TwoByteHandlers_0FXX = new OpCodeHandler[0x100] {
				// 00
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 08
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 10
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovups_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovups_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovups_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovupd_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovupd_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovupd_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_RM(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vmovss_xmm_k1z_xmm_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovss_xmm_k1z_m32, TupleType.Tuple1_Scalar)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_RM(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vmovsd_xmm_k1z_xmm_xmm, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovsd_xmm_k1z_m64, TupleType.Tuple1_Scalar)
						)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovups_xmmm128_k1z_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vmovups_ymmm256_k1z_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vmovups_zmmm512_k1z_zmm, TupleType.Full_Mem_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovupd_xmmm128_k1z_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vmovupd_ymmm256_k1z_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vmovupd_zmmm512_k1z_zmm, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_RM(
							new OpCodeHandler_EVEX_WkHV(Register.XMM0, Code.EVEX_Vmovss_xmm_k1z_xmm_xmm_0F11, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovss_m32_k1_xmm, TupleType.Tuple1_Scalar)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_RM(
							new OpCodeHandler_EVEX_WkHV(Register.XMM0, Code.EVEX_Vmovsd_xmm_k1z_xmm_xmm_0F11, TupleType.Tuple1_Scalar),
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovsd_m64_k1_xmm, TupleType.Tuple1_Scalar)
						)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VHW(Register.XMM0, Code.EVEX_Vmovhlps_xmm_xmm_xmm, Code.EVEX_Vmovlps_xmm_xmm_m64, TupleType.Tuple2),
							invalid,
							invalid
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VHM(Register.XMM0, Code.EVEX_Vmovlpd_xmm_xmm_m64, TupleType.Tuple1_Scalar),
							invalid,
							invalid
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovsldup_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovsldup_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovsldup_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovddup_xmm_k1z_xmmm64, TupleType.MOVDDUP_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovddup_ymm_k1z_ymmm256, TupleType.MOVDDUP_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovddup_zmm_k1z_zmmm512, TupleType.MOVDDUP_512)
						)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_MV(Register.XMM0, Code.EVEX_Vmovlps_m64_xmm, TupleType.Tuple2),
							invalid,
							invalid
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_MV(Register.XMM0, Code.EVEX_Vmovlpd_m64_xmm, TupleType.Tuple1_Scalar),
							invalid,
							invalid
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vunpcklps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vunpcklps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vunpcklps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vunpcklpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vunpcklpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vunpcklpd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vunpckhps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vunpckhps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vunpckhps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vunpckhpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vunpckhpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vunpckhpd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VHW(Register.XMM0, Code.EVEX_Vmovlhps_xmm_xmm_xmm, Code.EVEX_Vmovhps_xmm_xmm_m64, TupleType.Tuple2),
							invalid,
							invalid
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VHM(Register.XMM0, Code.EVEX_Vmovhpd_xmm_xmm_m64, TupleType.Tuple1_Scalar),
							invalid,
							invalid
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovshdup_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovshdup_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovshdup_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_MV(Register.XMM0, Code.EVEX_Vmovhps_m64_xmm, TupleType.Tuple2),
							invalid,
							invalid
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_MV(Register.XMM0, Code.EVEX_Vmovhpd_m64_xmm, TupleType.Tuple1_Scalar),
							invalid,
							invalid
						)
					),
					invalid,
					invalid
				),

				// 18
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 20
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 28
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovaps_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovaps_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovaps_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovapd_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovapd_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovapd_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovaps_xmmm128_k1z_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vmovaps_ymmm256_k1z_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vmovaps_zmmm512_k1z_zmm, TupleType.Full_Mem_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovapd_xmmm128_k1z_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vmovapd_ymmm256_k1z_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vmovapd_zmmm512_k1z_zmm, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					invalid,
					new OpCodeHandler_EVEX_V_H_Ev_er(Register.XMM0, Code.EVEX_Vcvtsi2ss_xmm_xmm_rm32_er, Code.EVEX_Vcvtsi2ss_xmm_xmm_rm64_er, TupleType.Tuple1_Scalar, onlySAE: false),
					new OpCodeHandler_EVEX_V_H_Ev_er(Register.XMM0, Code.EVEX_Vcvtsi2sd_xmm_xmm_rm32, Code.EVEX_Vcvtsi2sd_xmm_xmm_rm64_er, TupleType.Tuple1_Scalar, onlySAE: false, noERd: true)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_MV(Register.XMM0, Code.EVEX_Vmovntps_m128_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_MV(Register.YMM0, Code.EVEX_Vmovntps_m256_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_MV(Register.ZMM0, Code.EVEX_Vmovntps_m512_zmm, TupleType.Full_Mem_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_MV(Register.XMM0, Code.EVEX_Vmovntpd_m128_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_MV(Register.YMM0, Code.EVEX_Vmovntpd_m256_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_MV(Register.ZMM0, Code.EVEX_Vmovntpd_m512_zmm, TupleType.Full_Mem_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					invalid,
					new OpCodeHandler_EVEX_Gv_W_er(Register.XMM0, Code.EVEX_Vcvttss2si_r32_xmmm32_sae, Code.EVEX_Vcvttss2si_r64_xmmm32_sae, TupleType.Tuple1_Scalar_4, onlySAE: true),
					new OpCodeHandler_EVEX_Gv_W_er(Register.XMM0, Code.EVEX_Vcvttsd2si_r32_xmmm64_sae, Code.EVEX_Vcvttsd2si_r64_xmmm64_sae, TupleType.Tuple1_Scalar_8, onlySAE: true)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					invalid,
					new OpCodeHandler_EVEX_Gv_W_er(Register.XMM0, Code.EVEX_Vcvtss2si_r32_xmmm32_er, Code.EVEX_Vcvtss2si_r64_xmmm32_er, TupleType.Tuple1_Scalar_4, onlySAE: false),
					new OpCodeHandler_EVEX_Gv_W_er(Register.XMM0, Code.EVEX_Vcvtsd2si_r32_xmmm64_er, Code.EVEX_Vcvtsd2si_r64_xmmm64_er, TupleType.Tuple1_Scalar_8, onlySAE: false)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VW_er(Register.XMM0, Code.EVEX_Vucomiss_xmm_xmmm32_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VW_er(Register.XMM0, Code.EVEX_Vucomisd_xmm_xmmm64_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VW_er(Register.XMM0, Code.EVEX_Vcomiss_xmm_xmmm32_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VW_er(Register.XMM0, Code.EVEX_Vcomisd_xmm_xmmm64_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					),
					invalid,
					invalid
				),

				// 30
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 38
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 40
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 48
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 50
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Code.EVEX_Vsqrtps_xmm_k1z_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Code.EVEX_Vsqrtps_ymm_k1z_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vsqrtps_zmm_k1z_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Code.EVEX_Vsqrtpd_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Code.EVEX_Vsqrtpd_ymm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vsqrtpd_zmm_k1z_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vsqrtss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vsqrtsd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					)
				),
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vandps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vandps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vandps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vandpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vandpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vandpd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vandnps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vandnps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vandnps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vandnpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vandnpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vandnpd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vorps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vorps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vorps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vorpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vorpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vorpd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vxorps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vxorps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vxorps_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vxorpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vxorpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vxorpd_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// 58
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vaddps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vaddps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vaddps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vaddpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vaddpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vaddpd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vaddss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vaddsd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vmulps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vmulps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vmulps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vmulpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vmulpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vmulpd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vmulss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vmulsd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtps2pd_xmm_k1z_xmmm64b32, TupleType.Half_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.XMM0, Code.EVEX_Vcvtps2pd_ymm_k1z_xmmm128b32, TupleType.Half_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.YMM0, Code.EVEX_Vcvtps2pd_zmm_k1z_ymmm256b32_sae, TupleType.Half_512, onlySAE: true)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtpd2ps_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.YMM0, Code.EVEX_Vcvtpd2ps_xmm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.ZMM0, Code.EVEX_Vcvtpd2ps_ymm_k1z_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vcvtss2sd_xmm_k1z_xmm_xmmm32_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vcvtsd2ss_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Code.EVEX_Vcvtdq2ps_xmm_k1z_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Code.EVEX_Vcvtdq2ps_ymm_k1z_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vcvtdq2ps_zmm_k1z_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtqq2ps_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.YMM0, Code.EVEX_Vcvtqq2ps_xmm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.ZMM0, Code.EVEX_Vcvtqq2ps_ymm_k1z_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Code.EVEX_Vcvtps2dq_xmm_k1z_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Code.EVEX_Vcvtps2dq_ymm_k1z_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vcvtps2dq_zmm_k1z_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						invalid
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Code.EVEX_Vcvttps2dq_xmm_k1z_xmmm128b32, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Code.EVEX_Vcvttps2dq_ymm_k1z_ymmm256b32, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Code.EVEX_Vcvttps2dq_zmm_k1z_zmmm512b32_sae, TupleType.Full_512, onlySAE: true)
						),
						invalid
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vsubps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vsubps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vsubps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vsubpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vsubpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vsubpd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vsubss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vsubsd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vminps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vminps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vminps_zmm_k1z_zmm_zmmm512b32_sae, TupleType.Full_512, onlySAE: true)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vminpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vminpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vminpd_zmm_k1z_zmm_zmmm512b64_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vminss_xmm_k1z_xmm_xmmm32_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vminsd_xmm_k1z_xmm_xmmm64_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vdivps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vdivps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vdivps_zmm_k1z_zmm_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vdivpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vdivpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vdivpd_zmm_k1z_zmm_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vdivss_xmm_k1z_xmm_xmmm32_er, TupleType.Tuple1_Scalar, onlySAE: false),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vdivsd_xmm_k1z_xmm_xmmm64_er, TupleType.Tuple1_Scalar, onlySAE: false)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vmaxps_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vmaxps_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vmaxps_zmm_k1z_zmm_zmmm512b32_sae, TupleType.Full_512, onlySAE: true)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vmaxpd_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkHW_er(Register.YMM0, Code.EVEX_Vmaxpd_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkHW_er(Register.ZMM0, Code.EVEX_Vmaxpd_zmm_k1z_zmm_zmmm512b64_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vmaxss_xmm_k1z_xmm_xmmm32_sae, TupleType.Tuple1_Scalar, onlySAE: true),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_VkHW_er(Register.XMM0, Code.EVEX_Vmaxsd_xmm_k1z_xmm_xmmm64_sae, TupleType.Tuple1_Scalar, onlySAE: true)
					)
				),

				// 60
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpunpcklbw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpunpcklbw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpunpcklbw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpunpcklwd_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpunpcklwd_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpunpcklwd_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpunpckldq_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpunpckldq_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpunpckldq_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpacksswb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpacksswb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpacksswb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vpcmpgtb_k_k1_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vpcmpgtb_k_k1_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vpcmpgtb_k_k1_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vpcmpgtw_k_k1_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vpcmpgtw_k_k1_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vpcmpgtw_k_k1_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vpcmpgtd_k_k1_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vpcmpgtd_k_k1_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vpcmpgtd_k_k1_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpackuswb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpackuswb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpackuswb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),

				// 68
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpunpckhbw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpunpckhbw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpunpckhbw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpunpckhwd_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpunpckhwd_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpunpckhwd_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpunpckhdq_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpunpckhdq_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpunpckhdq_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpackssdw_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpackssdw_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpackssdw_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpunpcklqdq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpunpcklqdq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpunpcklqdq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpunpckhqdq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpunpckhqdq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpunpckhqdq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VX_Ev(Code.EVEX_Vmovd_xmm_rm32, Code.EVEX_Vmovq_xmm_rm64, TupleType.Tuple1_Scalar),
						invalid,
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovdqa32_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovdqa32_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovdqa32_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovdqa64_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovdqa64_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovdqa64_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovdqu32_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovdqu32_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovdqu32_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovdqu64_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovdqu64_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovdqu64_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovdqu8_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovdqu8_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovdqu8_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Code.EVEX_Vmovdqu16_xmm_k1z_xmmm128, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Code.EVEX_Vmovdqu16_ymm_k1z_ymmm256, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Code.EVEX_Vmovdqu16_zmm_k1z_zmmm512, TupleType.Full_Mem_512)
						)
					)
				),

				// 70
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkWIb(Register.XMM0, Code.EVEX_Vpshufd_xmm_k1z_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkWIb(Register.YMM0, Code.EVEX_Vpshufd_ymm_k1z_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkWIb(Register.ZMM0, Code.EVEX_Vpshufd_zmm_k1z_zmmm512b32_imm8, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkWIb(Register.XMM0, Code.EVEX_Vpshufhw_xmm_k1z_xmmm128_imm8, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkWIb(Register.YMM0, Code.EVEX_Vpshufhw_ymm_k1z_ymmm256_imm8, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkWIb(Register.ZMM0, Code.EVEX_Vpshufhw_zmm_k1z_zmmm512_imm8, TupleType.Full_Mem_512)
					),
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkWIb(Register.XMM0, Code.EVEX_Vpshuflw_xmm_k1z_xmmm128_imm8, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkWIb(Register.YMM0, Code.EVEX_Vpshuflw_ymm_k1z_ymmm256_imm8, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkWIb(Register.ZMM0, Code.EVEX_Vpshuflw_zmm_k1z_zmmm512_imm8, TupleType.Full_Mem_512)
					)
				),
				new OpCodeHandler_Group(handlers_Grp_0F71),
				new OpCodeHandler_Group(handlers_Grp_0F72),
				new OpCodeHandler_Group(handlers_Grp_0F73),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vpcmpeqb_k_k1_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vpcmpeqb_k_k1_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vpcmpeqb_k_k1_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vpcmpeqw_k_k1_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vpcmpeqw_k_k1_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vpcmpeqw_k_k1_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_KkHW(Register.XMM0, Code.EVEX_Vpcmpeqd_k_k1_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_KkHW(Register.YMM0, Code.EVEX_Vpcmpeqd_k_k1_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_KkHW(Register.ZMM0, Code.EVEX_Vpcmpeqd_k_k1_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				invalid,

				// 78
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvttps2udq_xmm_k1z_xmmm128b32, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.YMM0, Code.EVEX_Vcvttps2udq_ymm_k1z_ymmm256b32, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.ZMM0, Code.EVEX_Vcvttps2udq_zmm_k1z_zmmm512b32_sae, TupleType.Full_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvttpd2udq_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.YMM0, Code.EVEX_Vcvttpd2udq_xmm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.ZMM0, Code.EVEX_Vcvttpd2udq_ymm_k1z_zmmm512b64_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvttps2uqq_xmm_k1z_xmmm64b32, TupleType.Half_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.XMM0, Code.EVEX_Vcvttps2uqq_ymm_k1z_xmmm128b32, TupleType.Half_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.YMM0, Code.EVEX_Vcvttps2uqq_zmm_k1z_ymmm256b32_sae, TupleType.Half_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvttpd2uqq_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.YMM0, Code.EVEX_Vcvttpd2uqq_ymm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.ZMM0, Code.EVEX_Vcvttpd2uqq_zmm_k1z_zmmm512b64_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					new OpCodeHandler_EVEX_Gv_W_er(Register.XMM0, Code.EVEX_Vcvttss2usi_r32_xmmm32_sae, Code.EVEX_Vcvttss2usi_r64_xmmm32_sae, TupleType.Tuple1_Fixed_4, onlySAE: true),
					new OpCodeHandler_EVEX_Gv_W_er(Register.XMM0, Code.EVEX_Vcvttsd2usi_r32_xmmm64_sae, Code.EVEX_Vcvttsd2usi_r64_xmmm64_sae, TupleType.Tuple1_Fixed_8, onlySAE: true)
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtps2udq_xmm_k1z_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.YMM0, Code.EVEX_Vcvtps2udq_ymm_k1z_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.ZMM0, Code.EVEX_Vcvtps2udq_zmm_k1z_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtpd2udq_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.YMM0, Code.EVEX_Vcvtpd2udq_xmm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.ZMM0, Code.EVEX_Vcvtpd2udq_ymm_k1z_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtps2uqq_xmm_k1z_xmmm64b32, TupleType.Half_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.XMM0, Code.EVEX_Vcvtps2uqq_ymm_k1z_xmmm128b32, TupleType.Half_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.YMM0, Code.EVEX_Vcvtps2uqq_zmm_k1z_ymmm256b32_er, TupleType.Half_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtpd2uqq_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.YMM0, Code.EVEX_Vcvtpd2uqq_ymm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.ZMM0, Code.EVEX_Vcvtpd2uqq_zmm_k1z_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_EVEX_Gv_W_er(Register.XMM0, Code.EVEX_Vcvtss2usi_r32_xmmm32_er, Code.EVEX_Vcvtss2usi_r64_xmmm32_er, TupleType.Tuple1_Fixed_4, onlySAE: false),
					new OpCodeHandler_EVEX_Gv_W_er(Register.XMM0, Code.EVEX_Vcvtsd2usi_r32_xmmm64_er, Code.EVEX_Vcvtsd2usi_r64_xmmm64_er, TupleType.Tuple1_Fixed_8, onlySAE: false)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvttps2qq_xmm_k1z_xmmm64b32, TupleType.Half_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.XMM0, Code.EVEX_Vcvttps2qq_ymm_k1z_xmmm128b32, TupleType.Half_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.YMM0, Code.EVEX_Vcvttps2qq_zmm_k1z_ymmm256b32_sae, TupleType.Half_512, onlySAE: true)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvttpd2qq_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.YMM0, Code.EVEX_Vcvttpd2qq_ymm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.ZMM0, Code.EVEX_Vcvttpd2qq_zmm_k1z_zmmm512b64_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtudq2pd_xmm_k1z_xmmm64b32, TupleType.Half_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vcvtudq2pd_ymm_k1z_xmmm128b32, TupleType.Half_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.YMM0, Code.EVEX_Vcvtudq2pd_zmm_k1z_ymmm256b32, TupleType.Half_512)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtuqq2pd_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.YMM0, Code.EVEX_Vcvtuqq2pd_ymm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.ZMM0, Code.EVEX_Vcvtuqq2pd_zmm_k1z_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtudq2ps_xmm_k1z_xmmm128b32, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.YMM0, Code.EVEX_Vcvtudq2ps_ymm_k1z_ymmm256b32, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.ZMM0, Code.EVEX_Vcvtudq2ps_zmm_k1z_zmmm512b32_er, TupleType.Full_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtuqq2ps_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.YMM0, Code.EVEX_Vcvtuqq2ps_xmm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.ZMM0, Code.EVEX_Vcvtuqq2ps_ymm_k1z_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtps2qq_xmm_k1z_xmmm64b32, TupleType.Half_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.XMM0, Code.EVEX_Vcvtps2qq_ymm_k1z_xmmm128b32, TupleType.Half_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.YMM0, Code.EVEX_Vcvtps2qq_zmm_k1z_ymmm256b32_er, TupleType.Half_512, onlySAE: false)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtpd2qq_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.YMM0, Code.EVEX_Vcvtpd2qq_ymm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.ZMM0, Code.EVEX_Vcvtpd2qq_zmm_k1z_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_EVEX_V_H_Ev_er(Register.XMM0, Code.EVEX_Vcvtusi2ss_xmm_xmm_rm32_er, Code.EVEX_Vcvtusi2ss_xmm_xmm_rm64_er, TupleType.Tuple1_Fixed, onlySAE: false),
					new OpCodeHandler_EVEX_V_H_Ev_er(Register.XMM0, Code.EVEX_Vcvtusi2sd_xmm_xmm_rm32, Code.EVEX_Vcvtusi2sd_xmm_xmm_rm64_er, TupleType.Tuple1_Fixed, onlySAE: false, noERd: true)
				),
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_Ev_VX(Code.EVEX_Vmovd_rm32_xmm, Code.EVEX_Vmovq_rm64_xmm, TupleType.Tuple1_Scalar),
						invalid,
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VW(Register.XMM0, Code.EVEX_Vmovq_xmm_xmmm64, TupleType.Tuple1_Scalar),
							invalid,
							invalid
						)
					),
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovdqa32_xmmm128_k1z_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vmovdqa32_ymmm256_k1z_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vmovdqa32_zmmm512_k1z_zmm, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovdqa64_xmmm128_k1z_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vmovdqa64_ymmm256_k1z_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vmovdqa64_zmmm512_k1z_zmm, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovdqu32_xmmm128_k1z_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vmovdqu32_ymmm256_k1z_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vmovdqu32_zmmm512_k1z_zmm, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovdqu64_xmmm128_k1z_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vmovdqu64_ymmm256_k1z_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vmovdqu64_zmmm512_k1z_zmm, TupleType.Full_Mem_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovdqu8_xmmm128_k1z_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vmovdqu8_ymmm256_k1z_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vmovdqu8_zmmm512_k1z_zmm, TupleType.Full_Mem_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WkV(Register.XMM0, Code.EVEX_Vmovdqu16_xmmm128_k1z_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_WkV(Register.YMM0, Code.EVEX_Vmovdqu16_ymmm256_k1z_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_WkV(Register.ZMM0, Code.EVEX_Vmovdqu16_zmmm512_k1z_zmm, TupleType.Full_Mem_512)
						)
					)
				),

				// 80
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 88
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 90
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// 98
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// A0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// A8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// B0
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// B8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// C0
				invalid,
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_kkHWIb(Register.XMM0, Code.EVEX_Vcmpps_k_k1_xmm_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_kkHWIb(Register.YMM0, Code.EVEX_Vcmpps_k_k1_ymm_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_kkHWIb(Register.ZMM0, Code.EVEX_Vcmpps_k_k1_zmm_zmmm512b32_imm8_sae, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_kkHWIb(Register.XMM0, Code.EVEX_Vcmppd_k_k1_xmm_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_kkHWIb(Register.YMM0, Code.EVEX_Vcmppd_k_k1_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_kkHWIb(Register.ZMM0, Code.EVEX_Vcmppd_k_k1_zmm_zmmm512b64_imm8_sae, TupleType.Full_512)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_EVEX_kkHWIb(Register.XMM0, Code.EVEX_Vcmpss_k_k1_xmm_xmmm32_imm8_sae, TupleType.Tuple1_Scalar),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_EVEX_kkHWIb(Register.XMM0, Code.EVEX_Vcmpsd_k_k1_xmm_xmmm64_imm8_sae, TupleType.Tuple1_Scalar)
					)
				),
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_V_H_Ev_Ib(Register.XMM0, Code.EVEX_Vpinsrw_xmm_xmm_r32m16_imm8, Code.EVEX_Vpinsrw_xmm_xmm_r64m16_imm8, TupleType.Tuple1_Scalar_2, TupleType.Tuple1_Scalar_2),
							invalid,
							invalid
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_V_H_Ev_Ib(Register.XMM0, Code.EVEX_Vpinsrw_xmm_xmm_r32m16_imm8, Code.EVEX_Vpinsrw_xmm_xmm_r64m16_imm8, TupleType.Tuple1_Scalar_2, TupleType.Tuple1_Scalar_2),
							invalid,
							invalid
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_Ev_VX_Ib(Register.XMM0, Code.EVEX_Vpextrw_r32_xmm_imm8, Code.EVEX_Vpextrw_r64_xmm_imm8),
							invalid,
							invalid
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_Ev_VX_Ib(Register.XMM0, Code.EVEX_Vpextrw_r32_xmm_imm8, Code.EVEX_Vpextrw_r64_xmm_imm8),
							invalid,
							invalid
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vshufps_xmm_k1z_xmm_xmmm128b32_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vshufps_ymm_k1z_ymm_ymmm256b32_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vshufps_zmm_k1z_zmm_zmmm512b32_imm8, TupleType.Full_512)
						),
						invalid
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHWIb(Register.XMM0, Code.EVEX_Vshufpd_xmm_k1z_xmm_xmmm128b64_imm8, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHWIb(Register.YMM0, Code.EVEX_Vshufpd_ymm_k1z_ymm_ymmm256b64_imm8, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHWIb(Register.ZMM0, Code.EVEX_Vshufpd_zmm_k1z_zmm_zmmm512b64_imm8, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				invalid,

				// C8
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,
				invalid,

				// D0
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Register.XMM0, Register.XMM0, Code.EVEX_Vpsrlw_xmm_k1z_xmm_xmmm128, TupleType.Mem128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vpsrlw_ymm_k1z_ymm_xmmm128, TupleType.Mem128),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vpsrlw_zmm_k1z_zmm_xmmm128, TupleType.Mem128)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Register.XMM0, Register.XMM0, Code.EVEX_Vpsrld_xmm_k1z_xmm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vpsrld_ymm_k1z_ymm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vpsrld_zmm_k1z_zmm_xmmm128, TupleType.Mem128)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Register.XMM0, Register.XMM0, Code.EVEX_Vpsrlq_xmm_k1z_xmm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vpsrlq_ymm_k1z_ymm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vpsrlq_zmm_k1z_zmm_xmmm128, TupleType.Mem128)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpaddq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpaddq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpaddq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmullw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmullw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmullw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_WV(Register.XMM0, Code.EVEX_Vmovq_xmmm64_xmm, TupleType.Tuple1_Scalar),
							invalid,
							invalid
						)
					),
					invalid,
					invalid
				),
				invalid,

				// D8
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsubusb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsubusb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsubusb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsubusw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsubusw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsubusw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpminub_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpminub_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpminub_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpandd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpandd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpandd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpandq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpandq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpandq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpaddusb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpaddusb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpaddusb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpaddusw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpaddusw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpaddusw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmaxub_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmaxub_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmaxub_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpandnd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpandnd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpandnd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpandnq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpandnq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpandnq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// E0
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpavgb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpavgb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpavgb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Register.XMM0, Register.XMM0, Code.EVEX_Vpsraw_xmm_k1z_xmm_xmmm128, TupleType.Mem128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vpsraw_ymm_k1z_ymm_xmmm128, TupleType.Mem128),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vpsraw_zmm_k1z_zmm_xmmm128, TupleType.Mem128)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Register.XMM0, Register.XMM0, Code.EVEX_Vpsrad_xmm_k1z_xmm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vpsrad_ymm_k1z_ymm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vpsrad_zmm_k1z_zmm_xmmm128, TupleType.Mem128)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Register.XMM0, Register.XMM0, Code.EVEX_Vpsraq_xmm_k1z_xmm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vpsraq_ymm_k1z_ymm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vpsraq_zmm_k1z_zmm_xmmm128, TupleType.Mem128)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpavgw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpavgw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpavgw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmulhuw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmulhuw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmulhuw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmulhw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmulhw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmulhw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvttpd2dq_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.YMM0, Code.EVEX_Vcvttpd2dq_xmm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: true),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.ZMM0, Code.EVEX_Vcvttpd2dq_ymm_k1z_zmmm512b64_sae, TupleType.Full_512, onlySAE: true)
						)
					),
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkW(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtdq2pd_xmm_k1z_xmmm64b32, TupleType.Half_128),
							new OpCodeHandler_EVEX_VkW(Register.YMM0, Register.XMM0, Code.EVEX_Vcvtdq2pd_ymm_k1z_xmmm128b32, TupleType.Half_256),
							new OpCodeHandler_EVEX_VkW(Register.ZMM0, Register.YMM0, Code.EVEX_Vcvtdq2pd_zmm_k1z_ymmm256b32, TupleType.Half_512)
						),
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtqq2pd_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.YMM0, Code.EVEX_Vcvtqq2pd_ymm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.ZMM0, Register.ZMM0, Code.EVEX_Vcvtqq2pd_zmm_k1z_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					),
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX_er(
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.XMM0, Code.EVEX_Vcvtpd2dq_xmm_k1z_xmmm128b64, TupleType.Full_128, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.XMM0, Register.YMM0, Code.EVEX_Vcvtpd2dq_xmm_k1z_ymmm256b64, TupleType.Full_256, onlySAE: false),
							new OpCodeHandler_EVEX_VkW_er(Register.YMM0, Register.ZMM0, Code.EVEX_Vcvtpd2dq_ymm_k1z_zmmm512b64_er, TupleType.Full_512, onlySAE: false)
						)
					)
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_MV(Register.XMM0, Code.EVEX_Vmovntdq_m128_xmm, TupleType.Full_Mem_128),
							new OpCodeHandler_EVEX_MV(Register.YMM0, Code.EVEX_Vmovntdq_m256_ymm, TupleType.Full_Mem_256),
							new OpCodeHandler_EVEX_MV(Register.ZMM0, Code.EVEX_Vmovntdq_m512_zmm, TupleType.Full_Mem_512)
						),
						invalid
					),
					invalid,
					invalid
				),

				// E8
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsubsb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsubsb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsubsb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsubsw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsubsw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsubsw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpminsw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpminsw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpminsw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpord_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpord_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpord_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vporq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vporq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vporq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpaddsb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpaddsb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpaddsb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpaddsw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpaddsw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpaddsw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmaxsw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmaxsw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmaxsw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpxord_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpxord_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpxord_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpxorq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpxorq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpxorq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),

				// F0
				invalid,
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Register.XMM0, Register.XMM0, Code.EVEX_Vpsllw_xmm_k1z_xmm_xmmm128, TupleType.Mem128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vpsllw_ymm_k1z_ymm_xmmm128, TupleType.Mem128),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vpsllw_zmm_k1z_zmm_xmmm128, TupleType.Mem128)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Register.XMM0, Register.XMM0, Code.EVEX_Vpslld_xmm_k1z_xmm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vpslld_ymm_k1z_ymm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vpslld_zmm_k1z_zmm_xmmm128, TupleType.Mem128)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Register.XMM0, Register.XMM0, Code.EVEX_Vpsllq_xmm_k1z_xmm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Register.YMM0, Register.XMM0, Code.EVEX_Vpsllq_ymm_k1z_ymm_xmmm128, TupleType.Mem128),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Register.ZMM0, Register.XMM0, Code.EVEX_Vpsllq_zmm_k1z_zmm_xmmm128, TupleType.Mem128)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmuludq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmuludq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmuludq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpmaddwd_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpmaddwd_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpmaddwd_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VHW(Register.XMM0, Code.EVEX_Vpsadbw_xmm_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VHW(Register.YMM0, Code.EVEX_Vpsadbw_ymm_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VHW(Register.ZMM0, Code.EVEX_Vpsadbw_zmm_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				invalid,

				// F8
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsubb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsubb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsubb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsubw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsubw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsubw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsubd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsubd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsubd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						invalid,
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpsubq_xmm_k1z_xmm_xmmm128b64, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpsubq_ymm_k1z_ymm_ymmm256b64, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpsubq_zmm_k1z_zmm_zmmm512b64, TupleType.Full_512)
						)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpaddb_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpaddb_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpaddb_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_VectorLength_EVEX(
						new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpaddw_xmm_k1z_xmm_xmmm128, TupleType.Full_Mem_128),
						new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpaddw_ymm_k1z_ymm_ymmm256, TupleType.Full_Mem_256),
						new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpaddw_zmm_k1z_zmm_zmmm512, TupleType.Full_Mem_512)
					),
					invalid,
					invalid
				),
				new OpCodeHandler_MandatoryPrefix2(
					invalid,
					new OpCodeHandler_W(
						new OpCodeHandler_VectorLength_EVEX(
							new OpCodeHandler_EVEX_VkHW(Register.XMM0, Code.EVEX_Vpaddd_xmm_k1z_xmm_xmmm128b32, TupleType.Full_128),
							new OpCodeHandler_EVEX_VkHW(Register.YMM0, Code.EVEX_Vpaddd_ymm_k1z_ymm_ymmm256b32, TupleType.Full_256),
							new OpCodeHandler_EVEX_VkHW(Register.ZMM0, Code.EVEX_Vpaddd_zmm_k1z_zmm_zmmm512b32, TupleType.Full_512)
						),
						invalid
					),
					invalid,
					invalid
				),
				invalid,
			};
		}
	}
}
#endif
