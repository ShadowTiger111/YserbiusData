#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap23 : AMapScripted {
        protected override int MapIndex => 23;
        
        public YserMap23() {
            MapEvent01 = FnATELEA_01;
            MapEvent02 = FnRTELEB_02;
            MapEvent03 = FnNTELEC_03;
            MapEvent04 = FnATELED_04;
            MapEvent05 = FnKTELEE_05;
            MapEvent06 = FnKTELEF_06;
            MapEvent07 = FnITELEG_07;
            MapEvent08 = FnATELEH_08;
            MapEvent09 = FnNTELEI_09;
            MapEvent0A = FnARNKENCA_0A;
            MapEvent0C = FnTOENTRY_0C;
            MapEvent0D = FnETELEJ_0D;
            MapEvent0E = FnNTELEK_0E;
            MapEvent0F = FnLTELEL_0F;
            MapEvent10 = FnITELEG_10;
            MapEvent11 = FnKTELEL_11;
            MapEvent12 = FnLTELEN_12;
            MapEvent13 = FnENLKENCA_13;
            MapEvent15 = FnDTELEO_15;
            MapEvent16 = FnETELEP_16;
            MapEvent17 = FnRTELEQ_17;
            MapEvent18 = FnGTELER_18;
            MapEvent19 = FnHTELES_19;
            MapEvent1A = FnOTELET_1A;
            MapEvent1B = FnSTELEU_1B;
            MapEvent1C = FnTTELEV_1C;
            MapEvent1D = FnARNAKEND_1D;
            MapEvent1E = FnDTELEX_1E;
            MapEvent1F = FnRTELEY_1F;
            MapEvent20 = FnATELEZ_20;
            MapEvent21 = FnGTELEAA_21;
            MapEvent22 = FnOTELEBB_22;
            MapEvent23 = FnNTELECC_23;
            MapEvent24 = FnDRAGENCA_24;
            MapEvent25 = FnDRAGENCB_25;
            MapEvent26 = FnZTELEDD_26;
            MapEvent27 = FnITELEG_27;
            MapEvent28 = FnWTELEEE_28;
            MapEvent29 = FnVTELEWW_29;
            MapEvent2A = FnBTELEXX_2A;
            MapEvent2B = FnCTELEYY_2B;
            MapEvent2C = FnPTELEZZ_2C;
            MapEvent2D = FnMTELEXX_2D;
            MapEvent2E = FnJTELEYY_2E;
            MapEvent2F = FnUTELEWW_2F;
            MapEvent30 = FnXTELEWW_30;
            MapEvent31 = FnYTELEZZ_31;
            MapEvent32 = FnIENCA_32;
            MapEvent34 = FnWIZENCA_34;
            MapEvent35 = FnWIZENCB_35;
            MapEvent36 = FnWIZENCC_36;
            MapEvent37 = FnPIT_37;
            MapEvent38 = FnGHOSENCA_38;
            MapEvent3B = FnTXTGHOSB_3B;
            MapEvent3D = FnTXTGHOST_3D;
            MapEvent3E = FnENDRENCA_3E;
            MapEvent41 = FnBADEXIT_41;
            MapEvent45 = FnENTRENCA_45;
            MapEvent47 = FnLICHDOOR_47;
            MapEvent48 = FnENTRENCD_48;
            MapEvent49 = FnLICHA_49;
            MapEvent4A = FnLICHB_4A;
            MapEvent4B = FnLICHC_4B;
            MapEvent4C = FnLICHD_4C;
            MapEvent4D = FnLICHMAIN_4D;
            MapEvent4E = FnTXTLICH_4E;
            MapEvent4F = FnLABY_4F;
            MapEvent50 = FnTXTLABY_50;
            MapEvent51 = FnSETLICHA_51;
            MapEvent52 = FnSETLICHB_52;
            MapEvent53 = FnSETLICHC_53;
            MapEvent54 = FnSETLICHD_54;
        }
        
        // === Strings ================================================
        private const string String03FC = "Runes on magic wall --";
        private const string String0413 = "Alchemy";
        private const string String041B = "Runes on magic wall --";
        private const string String0432 = "Reverie";
        private const string String043A = "Runes on magic wall --";
        private const string String0451 = "Netherworld";
        private const string String045D = "Runes on magic wall --";
        private const string String0474 = "Arcane";
        private const string String047B = "Runes on magic wall --";
        private const string String0492 = "Karma";
        private const string String0498 = "Runes on magic wall --";
        private const string String04AF = "Karma";
        private const string String04B5 = "Runes on magic wall --";
        private const string String04CC = "Incantation";
        private const string String04D8 = "Runes on magic wall --";
        private const string String04EF = "Archaic";
        private const string String04F7 = "Runes on magic wall --";
        private const string String050E = "Netherworld";
        private const string String051A = "Secrets follow when you spell that which powers time.";
        private const string String0550 = "The gate takes you back to the Labyrinth.";
        private const string String057A = "Runes on magic wall --";
        private const string String0591 = "Ethereal";
        private const string String059A = "Runes on magic wall --";
        private const string String05B1 = "Netherworld";
        private const string String05BD = "Runes on magic wall --";
        private const string String05D4 = "Luck";
        private const string String05D9 = "Runes on magic wall --";
        private const string String05F0 = "Illusion";
        private const string String05F9 = "Runes on magic wall --";
        private const string String0610 = "Invulnerable";
        private const string String061D = "Runes on magic wall --";
        private const string String0634 = "Karma";
        private const string String063A = "Runes on magic wall --";
        private const string String0651 = "Luminous";
        private const string String065A = "Those which haunt this castle must be spelled to find their master.";
        private const string String069E = "Runes on magic wall --";
        private const string String06B5 = "Dust";
        private const string String06BA = "Runes on magic wall --";
        private const string String06D1 = "Enchant";
        private const string String06D9 = "Runes on magic wall --";
        private const string String06F0 = "Magic";
        private const string String06F6 = "Runes on magic wall --";
        private const string String070D = "Ghouls";
        private const string String0714 = "Runes on magic wall --";
        private const string String072B = "Hex";
        private const string String072F = "Runes on magic wall --";
        private const string String0746 = "Obsession";
        private const string String0750 = "Runes on magic wall --";
        private const string String0767 = "Sorcery";
        private const string String076F = "Runes on magic wall --";
        private const string String0786 = "Talisman";
        private const string String078F = "Both Arnakkian and Enlikil have been identified.";
        private const string String07C0 = "The Ghost takes you to the Guardians.";
        private const string String07E6 = "The master of this castle must be identified before the ghost may take you to him.";
        private const string String0839 = "Runes on magic wall --";
        private const string String0850 = "Druid";
        private const string String0856 = "Runes on magic wall --";
        private const string String086D = "Runes";
        private const string String0873 = "Runes on magic wall --";
        private const string String088A = "Alchemist";
        private const string String0894 = "Runes on magic wall --";
        private const string String08AB = "Ghost";
        private const string String08B1 = "Runes on magic wall --";
        private const string String08C8 = "Orb";
        private const string String08CC = "Runes on magic wall --";
        private const string String08E3 = "Nexus";
        private const string String08E9 = "Runes on magic wall --";
        private const string String0900 = "Zzyzx";
        private const string String0906 = "Runes on magic wall --";
        private const string String091D = "Illusive";
        private const string String0926 = "Runes on magic wall --";
        private const string String093D = "Wizard";
        private const string String0944 = "Runes on magic wall --";
        private const string String095B = "Vision";
        private const string String0962 = "Runes on magic wall --";
        private const string String0979 = "Bewitch";
        private const string String0981 = "Runes on magic wall --";
        private const string String0998 = "Conjure";
        private const string String09A0 = "Runes on magic wall --";
        private const string String09B7 = "Powerful";
        private const string String09C0 = "Runes on magic wall --";
        private const string String09D7 = "Magus";
        private const string String09DD = "Runes on magic wall --";
        private const string String09F4 = "Jinx";
        private const string String09F9 = "Runes on magic wall --";
        private const string String0A10 = "Unspeller";
        private const string String0A1A = "Runes on magic wall --";
        private const string String0A31 = "XxxX";
        private const string String0A36 = "Runes on magic wall --";
        private const string String0A4D = "Youth";
        private const string String0A53 = "You fall into the pit and die.";
        private const string String0A72 = "A message is written on a scroll.";
        private const string String0A94 = "'To gain access to Arnakkian's Chamber, you must defeat his lich apprentices.'";
        private const string String0AE3 = "A Cleric appears..";
        private const string String0AF6 = "'Beyond the words lies the power of the earth.'";
        private const string String0B26 = "The Wizard Door opens.";
        private const string String0B3D = "The symbol of the Four Corners magically radiates from this door.";
        private const string String0B7F = "The spirit of Arnakkian Slowfoot appears.";
        private const string String0BA9 = "Apprentices of Arnakkian roam these passageways.";
        private const string String0BDA = "This gate returns you to MAGE'S OVERLOOK.";
        
        // === Functions ================================================
        private void FnATELEA_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // Runes on magic wall --
            L0010: ShowRunes(party, String0413); // Alchemy
            L001D: TeleportParty(party, 0x34, 0x02, 0x8A, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnRTELEB_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String041B); // Runes on magic wall --
            L0010: ShowRunes(party, String0432); // Reverie
            L001D: TeleportParty(party, 0x34, 0x02, 0x38, 0x03, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnNTELEC_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String043A); // Runes on magic wall --
            L0010: ShowRunes(party, String0451); // Netherworld
            L001D: SetState(party, 0x02, 0x49, 0x02);
            L0032: TeleportParty(party, 0x34, 0x02, 0xE0, 0x02, isForwardMove);
            L004D: return; // RETURN;
        }

        private void FnATELED_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String045D); // Runes on magic wall --
            L0010: ShowRunes(party, String0474); // Arcane
            L001D: TeleportParty(party, 0x34, 0x02, 0xF2, 0x00, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnKTELEE_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String047B); // Runes on magic wall --
            L0010: ShowRunes(party, String0492); // Karma
            L001D: TeleportParty(party, 0x34, 0x02, 0xF5, 0x03, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnKTELEF_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0498); // Runes on magic wall --
            L0010: ShowRunes(party, String04AF); // Karma
            L001D: TeleportParty(party, 0x34, 0x02, 0xE3, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnITELEG_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04B5); // Runes on magic wall --
            L0010: ShowRunes(party, String04CC); // Incantation
            L001D: TeleportParty(party, 0x34, 0x02, 0xCC, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnATELEH_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x49), 0x0002);
            L0017: if (JumpNotEqual) goto L004E;
            L0019: ShowMessage(party, String04D8); // Runes on magic wall --
            L0026: ShowRunes(party, String04EF); // Archaic
            L0033: TeleportParty(party, 0x34, 0x02, 0xFA, 0x02, isForwardMove);
            L004E: return; // RETURN;
        }

        private void FnNTELEI_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04F7); // Runes on magic wall --
            L0010: ShowRunes(party, String050E); // Netherworld
            L001D: TeleportParty(party, 0x34, 0x02, 0x88, 0x00, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnARNKENCA_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState(party, 0x02, 0x52, 0x01);
            L0018: ShowMessage(party, String051A); // Secrets follow when you spell that which powers time.
            L0025: AddEncounter(party, 0x01, 0x19);
            L0037: AddEncounter(party, 0x02, 0x19);
            L0049: AddEncounter(party, 0x03, 0x19);
            L005B: AddEncounter(party, 0x05, 0x12);
            L006D: AddEncounter(party, 0x06, 0x12);
            L007F: AddTreasure(party, 0x01F4, 0x00, 0xCF, 0xCF, 0xC6, 0xC9);
            L00A1: return; // RETURN;
        }

        private void FnTOENTRY_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0550); // The gate takes you back to the Labyrinth.
            L0010: TeleportParty(party, 0x34, 0x02, 0x30, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnETELEJ_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String057A); // Runes on magic wall --
            L0010: ShowRunes(party, String0591); // Ethereal
            L001D: TeleportParty(party, 0x34, 0x02, 0xBB, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnNTELEK_0E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String059A); // Runes on magic wall --
            L0010: ShowRunes(party, String05B1); // Netherworld
            L001D: TeleportParty(party, 0x34, 0x02, 0xDA, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnLTELEL_0F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState(party, 0x02, 0x49, 0x03);
            L0018: ShowMessage(party, String05BD); // Runes on magic wall --
            L0025: ShowRunes(party, String05D4); // Luck
            L0032: TeleportParty(party, 0x34, 0x02, 0xB9, 0x02, isForwardMove);
            L004D: return; // RETURN;
        }

        private void FnITELEG_10(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x49), 0x0003);
            L0017: if (JumpNotEqual) goto L0050;
            L0019: ShowMessage(party, String05D9); // Runes on magic wall --
            L0026: ShowRunes(party, String05F0); // Illusion
            L0033: TeleportParty(party, 0x34, 0x02, 0xCC, 0x02, isForwardMove);
            L004E: goto L009B;
            L0050: Compare(GetState(party, 0x02, 0x49), 0x0004);
            L0064: if (JumpNotEqual) goto L009B;
            L0066: ShowMessage(party, String05F9); // Runes on magic wall --
            L0073: ShowRunes(party, String0610); // Invulnerable
            L0080: TeleportParty(party, 0x34, 0x02, 0xD8, 0x02, isForwardMove);
            L009B: return; // RETURN;
        }

        private void FnKTELEL_11(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState(party, 0x02, 0x49, 0x04);
            L0018: ShowMessage(party, String061D); // Runes on magic wall --
            L0025: ShowRunes(party, String0634); // Karma
            L0032: TeleportParty(party, 0x34, 0x02, 0xB9, 0x02, isForwardMove);
            L004D: return; // RETURN;
        }

        private void FnLTELEN_12(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String063A); // Runes on magic wall --
            L0010: ShowRunes(party, String0651); // Luminous
            L001D: TeleportParty(party, 0x34, 0x02, 0x6A, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnENLKENCA_13(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState(party, 0x02, 0x53, 0x01);
            L0018: ShowMessage(party, String065A); // Those which haunt this castle must be spelled to find their master.
            L0025: AddEncounter(party, 0x01, 0x19);
            L0037: AddEncounter(party, 0x02, 0x19);
            L0049: AddEncounter(party, 0x03, 0x19);
            L005B: AddEncounter(party, 0x04, 0x19);
            L006D: AddEncounter(party, 0x05, 0x19);
            L007F: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCF, 0xD0);
            L009F: return; // RETURN;
        }

        private void FnDTELEO_15(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState(party, 0x02, 0x49, 0x05);
            L0018: ShowMessage(party, String069E); // Runes on magic wall --
            L0025: ShowRunes(party, String06B5); // Dust
            L0032: TeleportParty(party, 0x34, 0x02, 0xB7, 0x02, isForwardMove);
            L004D: return; // RETURN;
        }

        private void FnETELEP_16(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06BA); // Runes on magic wall --
            L0010: ShowRunes(party, String06D1); // Enchant
            L001D: TeleportParty(party, 0x34, 0x02, 0xD6, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnRTELEQ_17(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06D9); // Runes on magic wall --
            L0010: ShowRunes(party, String06F0); // Magic
            L001D: TeleportParty(party, 0x34, 0x02, 0xD0, 0x03, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnGTELER_18(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06F6); // Runes on magic wall --
            L0010: ShowRunes(party, String070D); // Ghouls
            L001D: TeleportParty(party, 0x34, 0x02, 0x68, 0x00, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnHTELES_19(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0714); // Runes on magic wall --
            L0010: ShowRunes(party, String072B); // Hex
            L001D: TeleportParty(party, 0x34, 0x02, 0xAD, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnOTELET_1A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String072F); // Runes on magic wall --
            L0010: ShowRunes(party, String0746); // Obsession
            L001D: TeleportParty(party, 0x34, 0x02, 0x7E, 0x00, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnSTELEU_1B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0750); // Runes on magic wall --
            L0010: ShowRunes(party, String0767); // Sorcery
            L001D: TeleportParty(party, 0x34, 0x02, 0x5E, 0x00, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnTTELEV_1C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String076F); // Runes on magic wall --
            L0010: ShowRunes(party, String0786); // Talisman
            L001D: TeleportParty(party, 0x34, 0x02, 0xC2, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnARNAKEND_1D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetState(party, 0x02, 0x52));
            L0016: if (JumpEqual) goto L0064;
            L0018: RefreshCompareFlags(GetState(party, 0x02, 0x53));
            L002B: if (JumpEqual) goto L0064;
            L002D: ShowMessage(party, String078F); // Both Arnakkian and Enlikil have been identified.
            L003A: ShowMessage(party, String07C0); // The Ghost takes you to the Guardians.
            L0047: TeleportParty(party, 0x33, 0x02, 0x56, 0x02, isForwardMove);
            L0062: goto L0071;
            L0064: ShowMessage(party, String07E6); // The master of this castle must be identified before the ghost may take you to him.
            L0071: return; // RETURN;
        }

        private void FnDTELEX_1E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0839); // Runes on magic wall --
            L0010: ShowRunes(party, String0850); // Druid
            L001D: TeleportParty(party, 0x34, 0x02, 0x36, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnRTELEY_1F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0856); // Runes on magic wall --
            L0010: ShowRunes(party, String086D); // Runes
            L001D: TeleportParty(party, 0x34, 0x02, 0x3B, 0x00, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnATELEZ_20(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0873); // Runes on magic wall --
            L0010: ShowRunes(party, String088A); // Alchemist
            L001D: TeleportParty(party, 0x34, 0x02, 0x2C, 0x00, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnGTELEAA_21(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0894); // Runes on magic wall --
            L0010: ShowRunes(party, String08AB); // Ghost
            L001D: TeleportParty(party, 0x34, 0x02, 0x3E, 0x03, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnOTELEBB_22(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08B1); // Runes on magic wall --
            L0010: ShowRunes(party, String08C8); // Orb
            L001D: TeleportParty(party, 0x34, 0x02, 0x8E, 0x00, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnNTELECC_23(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08CC); // Runes on magic wall --
            L0010: ShowRunes(party, String08E3); // Nexus
            L001D: TeleportParty(party, 0x34, 0x02, 0xFD, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnDRAGENCA_24(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1A);
            L0015: AddEncounter(party, 0x02, 0x1A);
            L0027: AddEncounter(party, 0x03, 0x1A);
            L0039: AddEncounter(party, 0x04, 0x1A);
            L004B: AddEncounter(party, 0x05, 0x1B);
            L005D: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0xD0, 0xC8, 0xC6);
            L007E: return; // RETURN;
        }

        private void FnDRAGENCB_25(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1C);
            L0015: AddEncounter(party, 0x02, 0x1C);
            L0027: AddEncounter(party, 0x03, 0x1C);
            L0039: AddEncounter(party, 0x05, 0x07);
            L004B: AddEncounter(party, 0x06, 0x09);
            L005D: AddTreasure(party, 0x1F40, 0x00, 0xCF, 0xCF, 0xBC, 0xC7);
            L007F: return; // RETURN;
        }

        private void FnZTELEDD_26(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08E9); // Runes on magic wall --
            L0010: ShowRunes(party, String0900); // Zzyzx
            L001D: SetState(party, 0x02, 0x49, 0x01);
            L0032: TeleportParty(party, 0x34, 0x02, 0x27, 0x02, isForwardMove);
            L004D: return; // RETURN;
        }

        private void FnITELEG_27(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0906); // Runes on magic wall --
            L0010: ShowRunes(party, String091D); // Illusive
            L001D: TeleportParty(party, 0x34, 0x02, 0xCC, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnWTELEEE_28(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x49), 0x0001);
            L0017: if (JumpNotEqual) goto L004E;
            L0019: ShowMessage(party, String0926); // Runes on magic wall --
            L0026: ShowRunes(party, String093D); // Wizard
            L0033: TeleportParty(party, 0x34, 0x02, 0xE6, 0x02, isForwardMove);
            L004E: return; // RETURN;
        }

        private void FnVTELEWW_29(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0944); // Runes on magic wall --
            L0010: ShowRunes(party, String095B); // Vision
            L001D: TeleportParty(party, 0x34, 0x02, 0x07, 0x01, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnBTELEXX_2A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0962); // Runes on magic wall --
            L0010: ShowRunes(party, String0979); // Bewitch
            L001D: TeleportParty(party, 0x34, 0x02, 0x1D, 0x00, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnCTELEYY_2B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0981); // Runes on magic wall --
            L0010: ShowRunes(party, String0998); // Conjure
            L001D: TeleportParty(party, 0x34, 0x02, 0xBD, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnPTELEZZ_2C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09A0); // Runes on magic wall --
            L0010: ShowRunes(party, String09B7); // Powerful
            L001D: TeleportParty(party, 0x34, 0x02, 0x00, 0x33, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnMTELEXX_2D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09C0); // Runes on magic wall --
            L0010: ShowRunes(party, String09D7); // Magus
            L001D: TeleportParty(party, 0x34, 0x02, 0x1D, 0x00, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnJTELEYY_2E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09DD); // Runes on magic wall --
            L0010: ShowRunes(party, String09F4); // Jinx
            L001D: TeleportParty(party, 0x34, 0x02, 0xBD, 0x02, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnUTELEWW_2F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09F9); // Runes on magic wall --
            L0010: ShowRunes(party, String0A10); // Unspeller
            L001D: TeleportParty(party, 0x34, 0x02, 0x07, 0x01, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnXTELEWW_30(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A1A); // Runes on magic wall --
            L0010: ShowRunes(party, String0A31); // XxxX
            L001D: TeleportParty(party, 0x34, 0x02, 0x07, 0x01, isForwardMove);
            L0038: return; // RETURN;
        }

        private void FnYTELEZZ_31(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A36); // Runes on magic wall --
            L0010: ShowRunes(party, String0A4D); // Youth
            L001D: TeleportParty(party, 0x34, 0x02, 0x00, 0x33, isForwardMove);
            L0037: return; // RETURN;
        }

        private void FnIENCA_32(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x18);
            L0015: AddEncounter(party, 0x02, 0x18);
            L0027: AddEncounter(party, 0x03, 0x1E);
            L0039: AddEncounter(party, 0x05, 0x21);
            L004B: return; // RETURN;
        }

        private void FnWIZENCA_34(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1E);
            L0015: AddEncounter(party, 0x02, 0x1E);
            L0027: AddEncounter(party, 0x03, 0x18);
            L0039: AddEncounter(party, 0x04, 0x18);
            L004B: AddEncounter(party, 0x05, 0x21);
            L005D: AddEncounter(party, 0x06, 0x21);
            L006F: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCF, 0xB4);
            L008F: return; // RETURN;
        }

        private void FnWIZENCB_35(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1D);
            L0015: AddEncounter(party, 0x02, 0x1D);
            L0027: AddEncounter(party, 0x03, 0x1D);
            L0039: AddEncounter(party, 0x04, 0x1D);
            L004B: AddEncounter(party, 0x05, 0x18);
            L005D: AddEncounter(party, 0x06, 0x18);
            L006F: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCF, 0xC6);
            L008F: return; // RETURN;
        }

        private void FnWIZENCC_36(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1E);
            L0015: AddEncounter(party, 0x02, 0x1E);
            L0027: AddEncounter(party, 0x05, 0x18);
            L0039: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCF, 0xC8);
            L0059: return; // RETURN;
        }

        private void FnPIT_37(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A53); // You fall into the pit and die.
            L0010: DamagePlayer(party, GetMaxHits(party));
            L0021: return; // RETURN;
        }

        private void FnGHOSENCA_38(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x20);
            L0015: AddEncounter(party, 0x02, 0x20);
            L0027: AddEncounter(party, 0x03, 0x1F);
            L0039: AddEncounter(party, 0x04, 0x1F);
            L004B: AddEncounter(party, 0x06, 0x20);
            L005D: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xD1, 0xCF);
            L007D: return; // RETURN;
        }

        private void FnTXTGHOSB_3B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A72); // A message is written on a scroll.
            L0010: ShowMessage(party, String0A94); // 'To gain access to Arnakkian's Chamber, you must defeat his lich apprentices.'
            L001D: return; // RETURN;
        }

        private void FnTXTGHOST_3D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0029);
            L0010: ShowMessage(party, String0AE3); // A Cleric appears..
            L001D: ShowMessage(party, String0AF6); // 'Beyond the words lies the power of the earth.'
            L002A: return; // RETURN;
        }

        private void FnENDRENCA_3E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x20);
            L0027: AddEncounter(party, 0x04, 0x1F);
            L0039: AddEncounter(party, 0x05, 0x02);
            L004B: AddEncounter(party, 0x06, 0x02);
            L005D: AddTreasure(party, 0x0064, 0x00, 0xCF, 0xCF, 0xD0, 0xD0);
            L007F: return; // RETURN;
        }

        private void FnBADEXIT_41(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1E);
            L0015: AddEncounter(party, 0x02, 0x1E);
            L0027: AddEncounter(party, 0x03, 0x1E);
            L0039: AddEncounter(party, 0x04, 0x18);
            L004B: AddEncounter(party, 0x05, 0x19);
            L005D: AddEncounter(party, 0x06, 0x19);
            L006F: return; // RETURN;
        }

        private void FnENTRENCA_45(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x24);
            L0015: AddEncounter(party, 0x02, 0x25);
            L0027: AddEncounter(party, 0x03, 0x22);
            L0039: AddEncounter(party, 0x06, 0x23);
            L004B: return; // RETURN;
        }

        private void FnLICHDOOR_47(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetState(party, 0x01, 0x01));
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L00A5;
            L001B: RefreshCompareFlags(GetState(party, 0x01, 0x02));
            L002E: if (JumpEqual) goto L00A5;
            L0030: RefreshCompareFlags(GetState(party, 0x01, 0x03));
            L0043: if (JumpEqual) goto L00A5;
            L0045: RefreshCompareFlags(GetState(party, 0x01, 0x04));
            L0058: if (JumpEqual) goto L00A5;
            L005A: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0078: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0096: ShowMessage(party, String0B26); // The Wizard Door opens.
            L00A3: goto L00B2;
            L00A5: ShowMessage(party, String0B3D); // The symbol of the Four Corners magically radiates from this door.
            L00B2: return; // RETURN;
        }

        private void FnENTRENCD_48(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x19);
            L0015: AddEncounter(party, 0x02, 0x19);
            L0027: AddEncounter(party, 0x03, 0x18);
            L0039: AddEncounter(party, 0x04, 0x18);
            L004B: AddEncounter(party, 0x05, 0x19);
            L005D: AddEncounter(party, 0x06, 0x19);
            L006F: return; // RETURN;
        }

        private void FnLICHA_49(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x19);
            L0015: AddEncounter(party, 0x02, 0x19);
            L0027: AddEncounter(party, 0x05, 0x27);
            L0039: RefreshCompareFlags(GetState(party, 0x02, 0x8B));
            L004C: if (JumpEqual) goto L006E;
            L004E: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L006C: goto L00B3;
            L006E: SetState(party, 0x02, 0x8B, 0x01);
            L0083: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xB7, 0xD0);
            L00A2: AddExperience(party, 0x00002710);
            L00B3: return; // RETURN;
        }

        private void FnLICHB_4A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x19);
            L0015: AddEncounter(party, 0x02, 0x19);
            L0027: AddEncounter(party, 0x05, 0x27);
            L0039: RefreshCompareFlags(GetState(party, 0x02, 0x8C));
            L004C: if (JumpEqual) goto L006E;
            L004E: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xC6);
            L006C: goto L00B3;
            L006E: SetState(party, 0x02, 0x8C, 0x01);
            L0083: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xCD, 0xBD);
            L00A2: AddExperience(party, 0x00002710);
            L00B3: return; // RETURN;
        }

        private void FnLICHC_4B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x19);
            L0015: AddEncounter(party, 0x02, 0x19);
            L0027: AddEncounter(party, 0x05, 0x27);
            L0039: RefreshCompareFlags(GetState(party, 0x02, 0x8D));
            L004C: if (JumpEqual) goto L006E;
            L004E: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L006C: goto L00B3;
            L006E: SetState(party, 0x02, 0x8D, 0x01);
            L0083: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xC7, 0xB2);
            L00A2: AddExperience(party, 0x00002710);
            L00B3: return; // RETURN;
        }

        private void FnLICHD_4C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x19);
            L0015: AddEncounter(party, 0x02, 0x19);
            L0027: AddEncounter(party, 0x05, 0x27);
            L0039: RefreshCompareFlags(GetState(party, 0x02, 0x8E));
            L004C: if (JumpEqual) goto L006E;
            L004E: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L006C: goto L00B3;
            L006E: SetState(party, 0x02, 0x8E, 0x01);
            L0083: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xAC, 0xB7);
            L00A2: AddExperience(party, 0x00002710);
            L00B3: return; // RETURN;
        }

        private void FnLICHMAIN_4D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B7F); // The spirit of Arnakkian Slowfoot appears.
            L0010: AddEncounter(party, 0x01, 0x27);
            L0022: AddEncounter(party, 0x02, 0x27);
            L0034: AddEncounter(party, 0x03, 0x27);
            L0046: AddEncounter(party, 0x04, 0x27);
            L0058: AddEncounter(party, 0x05, 0x28);
            L006A: ax = HasItem(party, 0xF7);
            L0078: if (JumpEqual) goto L009A;
            L007A: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0098: goto L00F6;
            L009A: AddTreasure(party, 0x0000, 0x00, 0x00, 0x50, 0x50, 0x2D);
            L00BA: RefreshCompareFlags(GetState(party, 0x02, 0x89));
            L00CD: if (JumpNotEqual) goto L00F6;
            L00CF: SetState(party, 0x02, 0x89, 0x01);
            L00E4: AddExperience(party, 0x000B71B0);
            L00F6: return; // RETURN;
        }

        private void FnTXTLICH_4E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0BA9); // Apprentices of Arnakkian roam these passageways.
            L0010: return; // RETURN;
        }

        private void FnLABY_4F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x34, 0x01, 0x3F, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTXTLABY_50(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0BDA); // This gate returns you to MAGE'S OVERLOOK.
            L0010: return; // RETURN;
        }

        private void FnSETLICHA_51(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetState(party, 0x01, 0x01));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetState(party, 0x01, 0x01, 0x01);
            L002D: return; // RETURN;
        }

        private void FnSETLICHB_52(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetState(party, 0x01, 0x02));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetState(party, 0x01, 0x02, 0x01);
            L002D: return; // RETURN;
        }

        private void FnSETLICHC_53(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetState(party, 0x01, 0x03));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetState(party, 0x01, 0x03, 0x01);
            L002D: return; // RETURN;
        }

        private void FnSETLICHD_54(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetState(party, 0x01, 0x04));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetState(party, 0x01, 0x04, 0x01);
            L002D: return; // RETURN;
        }

    }
}
