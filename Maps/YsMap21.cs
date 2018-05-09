#pragma warning disable
using ZCF.WorldData;

namespace ZCF.Scripts.Maps {
    class YserMap21 : AMapScript {
        // === Strings ================================================
        private const string String03FC = "You step into a bottomless pit and die.";
        private const string String0424 = "Guardians stand ready.  'We are sworn to defend Arnakkian.'";
        private const string String0460 = "Earth Elemental Andreas rises from his mountainous perch.";
        private const string String049A = "Enlikil's Phantasm Guardians stand watch over the entrance to Arnakkian's Tomb.";
        private const string String04EA = "The earth elemental palace is filled with a bounty of priceless gems.  It seems to shake with great power.";
        private const string String0555 = "The Endless Void has ruptured your dimensionand forms a chasm between here and a distant platform.";
        private const string String05B8 = "A voice whispers 'Only true friendship can bridge the gap of time.'";
        private const string String05FC = "Quiet solitude fills the chasm.  You are on the other side.";
        private const string String0638 = "The wall glows.";
        private const string String0648 = "The wall glows.";
        private const string String0658 = "The wall glows.";
        private const string String0668 = "The wall glows.";
        private const string String0678 = "The wall glows.";
        private const string String0688 = "The wall glows.";
        private const string String0698 = "The wall glows.";
        private const string String06A8 = "The wall glows.";
        private const string String06B8 = "The wall glows.";
        private const string String06C8 = "The wall glows.";
        private const string String06D8 = "The wall glows.";
        private const string String06E8 = "The wall glows.";
        private const string String06F8 = "The wall glows.";
        private const string String0708 = "Your decision on where to step next saves you.";
        private const string String0737 = "You step over the edge and into oblivion.";
        private const string String0761 = "You selected your next move wisely.";
        private const string String0785 = "You step over the edge and into oblivion.";
        private const string String07AF = "Your next step is a safe one.";
        private const string String07CD = "You step over the edge and into oblivion.";
        private const string String07F7 = "The step you take is wisely chosen.";
        private const string String081B = "You step over the edge and into oblivion.";
        private const string String0845 = "You take one good step forward.";
        private const string String0865 = "You step over the edge and into oblivion.";
        private const string String088F = "You safely step forward.";
        private const string String08A8 = "You step over the edge and into oblivion.";
        private const string String08D2 = "You take a step in the right direction,";
        private const string String08FA = "You step over the edge and into oblivion.";
        private const string String0924 = "Your move is wise.";
        private const string String0937 = "You step over the edge and into oblivion.";
        private const string String0961 = "You select your next move wisely.";
        private const string String0983 = "You step over the edge and into oblivion.";
        private const string String09AD = "You move forward with confidence.";
        private const string String09CF = "You step over the edge and into oblivion.";
        private const string String09F9 = "Your next step is a good one.";
        private const string String0A17 = "You step over the edge and into oblivion.";
        private const string String0A41 = "You move ahead assuredly.";
        private const string String0A5B = "You step over the edge and into oblivion.";
        private const string String0A85 = "You choose your next step correctly.";
        private const string String0AAA = "You step over the edge and into oblivion.";
        private const string String0AD4 = "Your choice of movement saves you.";
        private const string String0AF7 = "You step over the edge and into oblivion.";
        private const string String0B21 = "You step in the right direction.";
        private const string String0B42 = "You step over the edge and into oblivion.";
        private const string String0B6C = "You select your next step wisely.";
        private const string String0B8E = "You step over the edge and into oblivion.";
        private const string String0BB8 = "Your next step is sagely chosen.";
        private const string String0BD9 = "You step over the edge and into oblivion.";
        private const string String0C03 = "You take a wise step forward.";
        private const string String0C21 = "You step over the edge and into oblivion.";
        private const string String0C4B = "You move forward wisely.";
        private const string String0C64 = "You step over the edge and into oblivion.";
        private const string String0C8E = "Your next step is wisely decided.";
        private const string String0CB0 = "You step over the edge and into oblivion.";
        private const string String0CDA = "You step ahead with confidence.";
        private const string String0CFA = "You step over the edge and into oblivion.";
        private const string String0D24 = "You move forward carefully.";
        private const string String0D40 = "You step over the edge and into oblivion.";
        private const string String0D6A = "You move ahead.";
        private const string String0D7A = "You step over the edge and into oblivion.";
        private const string String0DA4 = "Your step is wisely selected.";
        private const string String0DC2 = "You step over the edge and into oblivion.";
        private const string String0DEC = "You forge ahead.";
        private const string String0DFD = "You step over the edge and into oblivion.";
        private const string String0E27 = "You select your next move wisely.";
        private const string String0E49 = "You step over the edge and into oblivion.";
        private const string String0E73 = "Good sense guides your feet.";
        private const string String0E90 = "You step over the edge and into oblivion.";
        private const string String0EBA = "You walk ahead.";
        private const string String0ECA = "You step over the edge and into oblivion.";
        private const string String0EF4 = "Your next step is assuredly taken.";
        private const string String0F17 = "You step over the edge and into oblivion.";
        private const string String0F41 = "The next step is an intelligent one.";
        private const string String0F66 = "You step over the edge and into oblivion.";
        private const string String0F90 = "You move safely ahead.";
        private const string String0FA7 = "You step over the edge and into oblivion.";
        private const string String0FD1 = "Your movement decision was correct.";
        private const string String0FF5 = "You step over the edge and into oblivion.";
        private const string String101F = "You move forward with confidence.";
        private const string String1041 = "You step over the edge and into oblivion.";
        private const string String106B = "You carefully selected your next step.";
        private const string String1092 = "You step over the edge and into oblivion.";
        private const string String10BC = "You make a sage choice.";
        private const string String10D4 = "You step over the edge and into oblivion.";
        private const string String10FE = "You have made a wise decision.";
        private const string String111D = "You step over the edge and into oblivion.";
        private const string String1147 = "Andreas no longer defends this door.";
        private const string String116C = "The Earth Elemental holds power over this door.";
        private const string String119C = "A magic field grabs you and teleports you down into Arnakkian's tomb.  The laugh of an ancient archmage fills the chamber.";
        
        // === Functions ================================================
        protected override MapEventHandler MapEvent01 => FnPIT_01;
        private void FnPIT_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // You step into a bottomless pit and die.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: return; // RETURN;
        }

        protected override MapEventHandler MapEvent02 => FnENCGUARD_02;
        private void FnENCGUARD_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0424); // Guardians stand ready.  'We are sworn to defend Arnakkian.'
            L0010: AddEncounter(party, 0x01, 0x27);
            L0022: AddEncounter(party, 0x02, 0x27);
            L0034: AddEncounter(party, 0x03, 0x27);
            L0046: AddEncounter(party, 0x04, 0x27);
            L0058: AddEncounter(party, 0x05, 0x27);
            L006A: ax = CheckState04(party, 0x02, 0x88);
            L007B: RefreshCompareFlags(ax);
            L007D: if (!CompareResultEqual) goto L00A6;
            L007F: SetState00(party, 0x02, 0x88, 0x01);
            L0094: AddExperience98(party, 0x0007A120);
            L00A6: return; // RETURN;
        }

        protected override MapEventHandler MapEvent03 => FnENCEARTH_03;
        private void FnENCEARTH_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x01);
            L0014: RefreshCompareFlags(ax);
            L0016: if (CompareResultEqual) goto L001B;
            L0018: goto L0123;
            L001B: ShowMessage(party, String0460); // Earth Elemental Andreas rises from his mountainous perch.
            L0028: AddEncounter(party, 0x01, 0x04);
            L003A: AddEncounter(party, 0x02, 0x04);
            L004C: AddEncounter(party, 0x03, 0x22);
            L005E: AddEncounter(party, 0x04, 0x0F);
            L0070: AddEncounter(party, 0x05, 0x23);
            L0082: AddEncounter(party, 0x06, 0x28);
            L0094: ax = HasItem50(party, 0xE9);
            L00A2: if (CompareResultEqual) goto L00C6;
            L00A4: AddTreasure(party, 0x0000, 0x00, 0x00, 0x50, 0x50, 0xD0);
            L00C4: goto L0123;
            L00C6: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x88, 0x1D, 0xE9);
            L00E7: ax = CheckState04(party, 0x02, 0x8A);
            L00F8: RefreshCompareFlags(ax);
            L00FA: if (!CompareResultEqual) goto L0123;
            L00FC: SetState00(party, 0x02, 0x8A, 0x01);
            L0111: AddExperience98(party, 0x0003D090);
            L0123: return; // RETURN;
        }

        protected override MapEventHandler MapEvent04 => FnGUARDIAN_04;
        private void FnGUARDIAN_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String049A); // Enlikil's Phantasm Guardians stand watch over the entrance to Arnakkian's Tomb.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent05 => FnEARTHELE_05;
        private void FnEARTHELE_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x01);
            L0014: RefreshCompareFlags(ax);
            L0016: if (!CompareResultEqual) goto L0025;
            L0018: ShowMessage(party, String04EA); // The earth elemental palace is filled with a bounty of priceless gems.  It seems to shake with great power.
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent06 => FnPLATA_06;
        private void FnPLATA_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0555); // The Endless Void has ruptured your dimensionand forms a chasm between here and a distant platform.
            L0010: ShowMessage(party, String05B8); // A voice whispers 'Only true friendship can bridge the gap of time.'
            L001D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent07 => FnPLATB_07;
        private void FnPLATB_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05FC); // Quiet solitude fills the chasm.  You are on the other side.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent08 => FnYBOXA_08;
        private void FnYBOXA_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0638); // The wall glows.
            L0010: SetState00(party, 0x01, 0x02, 0x01);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent09 => FnYBOXB_09;
        private void FnYBOXB_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0648); // The wall glows.
            L0010: SetState00(party, 0x01, 0x02, 0x02);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0A => FnYBOXC_0A;
        private void FnYBOXC_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0658); // The wall glows.
            L0010: SetState00(party, 0x01, 0x02, 0x03);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0B => FnYBOXD_0B;
        private void FnYBOXD_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0668); // The wall glows.
            L0010: SetState00(party, 0x01, 0x02, 0x04);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0C => FnYBOXE_0C;
        private void FnYBOXE_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0678); // The wall glows.
            L0010: SetState00(party, 0x01, 0x02, 0x05);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0D => FnYBOXF_0D;
        private void FnYBOXF_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0688); // The wall glows.
            L0010: SetState00(party, 0x01, 0x02, 0x06);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0E => FnXBOXG_0E;
        private void FnXBOXG_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0698); // The wall glows.
            L0010: SetState00(party, 0x01, 0x03, 0x01);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0F => FnXBOXH_0F;
        private void FnXBOXH_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06A8); // The wall glows.
            L0010: SetState00(party, 0x01, 0x03, 0x02);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent10 => FnXBOXI_10;
        private void FnXBOXI_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06B8); // The wall glows.
            L0010: SetState00(party, 0x01, 0x03, 0x03);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent11 => FnXBOXJ_11;
        private void FnXBOXJ_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06C8); // The wall glows.
            L0010: SetState00(party, 0x01, 0x03, 0x04);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent12 => FnXBOXK_12;
        private void FnXBOXK_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06D8); // The wall glows.
            L0010: SetState00(party, 0x01, 0x03, 0x05);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent13 => FnXBOXL_13;
        private void FnXBOXL_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06E8); // The wall glows.
            L0010: SetState00(party, 0x01, 0x03, 0x06);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent14 => FnXBOXM_14;
        private void FnXBOXM_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06F8); // The wall glows.
            L0010: SetState00(party, 0x01, 0x03, 0x07);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent15 => FnPITAJ_15;
        private void FnPITAJ_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0004);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0708); // Your decision on where to step next saves you.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0737); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent16 => FnPITAK_16;
        private void FnPITAK_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0005);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0761); // You selected your next move wisely.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0785); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent17 => FnPITAL_17;
        private void FnPITAL_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0006);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String07AF); // Your next step is a safe one.
            L003C: goto L005C;
            L003E: ShowMessage(party, String07CD); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent18 => FnPITAM_18;
        private void FnPITAM_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0001);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0007);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String07F7); // The step you take is wisely chosen.
            L003C: goto L005C;
            L003E: ShowMessage(party, String081B); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent19 => FnPITBG_19;
        private void FnPITBG_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0002);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0001);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0845); // You take one good step forward.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0865); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1A => FnPITBI_1A;
        private void FnPITBI_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0002);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0003);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String088F); // You safely step forward.
            L003C: goto L005C;
            L003E: ShowMessage(party, String08A8); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1B => FnPITBJ_1B;
        private void FnPITBJ_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0002);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0004);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String08D2); // You take a step in the right direction,
            L003C: goto L005C;
            L003E: ShowMessage(party, String08FA); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1C => FnPITBK_1C;
        private void FnPITBK_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0002);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0005);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0924); // Your move is wise.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0937); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1D => FnPITBL_1D;
        private void FnPITBL_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0002);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0006);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0961); // You select your next move wisely.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0983); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1E => FnPITBM_1E;
        private void FnPITBM_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0002);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0007);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String09AD); // You move forward with confidence.
            L003C: goto L005C;
            L003E: ShowMessage(party, String09CF); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1F => FnPITCG_1F;
        private void FnPITCG_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0003);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0001);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String09F9); // Your next step is a good one.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0A17); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent20 => FnPITCH_20;
        private void FnPITCH_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0003);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0002);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0A41); // You move ahead assuredly.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0A5B); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent21 => FnPITCI_21;
        private void FnPITCI_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0003);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0003);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0A85); // You choose your next step correctly.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0AAA); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent22 => FnPITCJ_22;
        private void FnPITCJ_22(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0003);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0004);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0AD4); // Your choice of movement saves you.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0AF7); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent23 => FnPITCK_23;
        private void FnPITCK_23(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0003);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0005);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0B21); // You step in the right direction.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0B42); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent24 => FnPITCL_24;
        private void FnPITCL_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0003);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0006);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0B6C); // You select your next step wisely.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0B8E); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent25 => FnPITCM_25;
        private void FnPITCM_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0003);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0007);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0BB8); // Your next step is sagely chosen.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0BD9); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent26 => FnPITDG_26;
        private void FnPITDG_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0004);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0001);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0C03); // You take a wise step forward.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0C21); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent27 => FnPITDH_27;
        private void FnPITDH_27(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0004);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0002);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0C4B); // You move forward wisely.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0C64); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent28 => FnPITDI_28;
        private void FnPITDI_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0004);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0003);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0C8E); // Your next step is wisely decided.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0CB0); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent29 => FnPITDJ_29;
        private void FnPITDJ_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0004);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0004);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0CDA); // You step ahead with confidence.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0CFA); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2A => FnPITDK_2A;
        private void FnPITDK_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0004);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0005);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0D24); // You move forward carefully.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0D40); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2B => FnPITDL_2B;
        private void FnPITDL_2B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0004);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0006);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0D6A); // You move ahead.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0D7A); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2C => FnPITDM_2C;
        private void FnPITDM_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0004);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0007);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0DA4); // Your step is wisely selected.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0DC2); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2D => FnPITEG_2D;
        private void FnPITEG_2D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0005);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0001);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0DEC); // You forge ahead.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0DFD); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2E => FnPITEH_2E;
        private void FnPITEH_2E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0005);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0002);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0E27); // You select your next move wisely.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0E49); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2F => FnPITEI_2F;
        private void FnPITEI_2F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0005);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0003);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0E73); // Good sense guides your feet.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0E90); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent30 => FnPITEJ_30;
        private void FnPITEJ_30(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0005);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0004);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0EBA); // You walk ahead.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0ECA); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent31 => FnPITEK_31;
        private void FnPITEK_31(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0005);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0005);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0EF4); // Your next step is assuredly taken.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0F17); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent32 => FnPITFG_32;
        private void FnPITFG_32(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0006);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0001);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0F41); // The next step is an intelligent one.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0F66); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent33 => FnPITFH_33;
        private void FnPITFH_33(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0006);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0002);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0F90); // You move safely ahead.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0FA7); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent34 => FnPITFI_34;
        private void FnPITFI_34(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0006);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0003);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String0FD1); // Your movement decision was correct.
            L003C: goto L005C;
            L003E: ShowMessage(party, String0FF5); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent35 => FnPITFJ_35;
        private void FnPITFJ_35(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0006);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0004);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String101F); // You move forward with confidence.
            L003C: goto L005C;
            L003E: ShowMessage(party, String1041); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent36 => FnPITFK_36;
        private void FnPITFK_36(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0006);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0005);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String106B); // You carefully selected your next step.
            L003C: goto L005C;
            L003E: ShowMessage(party, String1092); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent37 => FnPITFL_37;
        private void FnPITFL_37(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0006);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0006);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String10BC); // You make a sage choice.
            L003C: goto L005C;
            L003E: ShowMessage(party, String10D4); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent38 => FnPITFM_38;
        private void FnPITFM_38(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x02);
            L0014: Compare(ax, 0x0006);
            L0017: if (!CompareResultEqual) goto L003E;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0007);
            L002D: if (!CompareResultEqual) goto L003E;
            L002F: ShowMessage(party, String10FE); // You have made a wise decision.
            L003C: goto L005C;
            L003E: ShowMessage(party, String111D); // You step over the edge and into oblivion.
            L004B: ax = GetMaxHits74(party);
            L0052: DoDamage90(party, ax);
            L005C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent39 => FnENCPITBJ_39;
        private void FnENCPITBJ_39(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x19);
            L0015: AddEncounter(party, 0x02, 0x1A);
            L0027: AddEncounter(party, 0x03, 0x1A);
            L0039: AddEncounter(party, 0x04, 0x1B);
            L004B: AddEncounter(party, 0x05, 0x1C);
            L005D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3A => FnENCPITDI_3A;
        private void FnENCPITDI_3A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x1F);
            L0027: AddEncounter(party, 0x03, 0x20);
            L0039: AddEncounter(party, 0x04, 0x20);
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3B => FnPITENCDK_3B;
        private void FnPITENCDK_3B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1B);
            L0015: AddEncounter(party, 0x02, 0x1B);
            L0027: AddEncounter(party, 0x03, 0x19);
            L0039: AddEncounter(party, 0x04, 0x19);
            L004B: AddEncounter(party, 0x05, 0x1B);
            L005D: AddEncounter(party, 0x06, 0x1B);
            L006F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3C => FnPITENCBL_3C;
        private void FnPITENCBL_3C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x24);
            L0015: AddEncounter(party, 0x02, 0x24);
            L0027: AddEncounter(party, 0x03, 0x24);
            L0039: AddEncounter(party, 0x04, 0x25);
            L004B: AddEncounter(party, 0x05, 0x26);
            L005D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3D => FnDOORARNK_3D;
        private void FnDOORARNK_3D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x01);
            L0014: RefreshCompareFlags(ax);
            L0016: if (CompareResultEqual) goto L005B;
            L0018: PushStack(0x01);
            L001C: PushStack(0x03);
            L0020: ax = GetNextTile20(party);
            L0027: PushStack(ax);
            L0028: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0032: PushStack(0x03);
            L0036: ax = GetNextTile20(party);
            L003D: PushStack(ax);
            L003E: PushStack(0x01);
            L0042: SetUnblocked30(party);
            L004C: ShowMessage(party, String1147); // Andreas no longer defends this door.
            L0059: goto L0068;
            L005B: ShowMessage(party, String116C); // The Earth Elemental holds power over this door.
            L0068: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3E => FnTELEARNK_3E;
        private void FnTELEARNK_3E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String119C); // A magic field grabs you and teleports you down into Arnakkian's tomb.  The laugh of an ancient archmage fills the chamber.
            L0010: SetMoveMap(party, 0x34, 0x02, 0x76, 0x03);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3F => FnSETEKILL_3F;
        private void FnSETEKILL_3F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x01, 0x01, 0x01);
            L0018: return; // RETURN;
        }

    }
}