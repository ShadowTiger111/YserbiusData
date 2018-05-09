namespace ZCF.Scripts.Maps {
    class YserMap31 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "The River of Eternity taps your life energy.";
        private const string String0429 = "You have died.";
        private const string String0438 = "Only the bravest adventurers explore the River for hidden passages.";
        private const string String047C = "The Ageless Void swallows you whole.";
        private const string String04A1 = "SageCross Fountain revives your Health and Mana";
        private const string String04D1 = "DragonBreath Fountain empowers you with improved attributes.";
        private const string String050E = "Minotaur Fountain revives your Health and Mana";
        private const string String053D = "As you reach the platform, a magical field envelops you and teleports you to a moon tapestry.";
        private const string String059B = "A magical door appears where the tapestry used to be.";
        private const string String05D1 = "A brilliant tapestry depicting moons decorates this room.";
        private const string String060B = "A Gnome Thief steps out of the shadows -";
        private const string String0634 = "'You are very near the final battle with the Elemental En-Li-Kil.";
        private const string String0676 = "The four Rainbow Gems will light your way to the infinite beyond when they are all placed.";
        private const string String06D1 = "Red, yellow, green and blue are the rainbow colors.";
        private const string String0705 = "Have your boat when the gems are set and sail the rainbow to your destiny.'";
        private const string String0751 = "A doorway is marked -- 'Voranti's Treasure'";
        private const string String077D = "Various golden objects appear to be standing to the west, just at the edge of the Ageless Void.";
        private const string String07DD = "A beam of red arcs over the Ageless Void.";
        private const string String0807 = "A vibrant rainbow of color forms.";
        private const string String0829 = "A golden statue appears to be capable of holding a gem.";
        private const string String0861 = "Your miniature Golden Boat floats out of your pack on a swirl of magic dust.";
        private const string String08AE = "It intersects the Rainbow and bursts into blinding light.";
        private const string String08E8 = "Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.";
        private const string String0954 = "A rainbow voyage across the Ageless Void awaits you to the West.";
        private const string String0995 = "A beam of yellow arcs over the Ageless Void.";
        private const string String09C2 = "A vibrant rainbow of color forms.";
        private const string String09E4 = "Your miniature Golden Boat floats out of your pack on a swirl of magic dust.";
        private const string String0A31 = "It intersects the Rainbow and bursts into blinding light.";
        private const string String0A6B = "Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.";
        private const string String0AD7 = "A rainbow voyage across the Ageless Void awaits you to the West.";
        private const string String0B18 = "A beam of green arcs over the Ageless Void.";
        private const string String0B44 = "A vibrant rainbow of color forms.";
        private const string String0B66 = "Your miniature Golden Boat floats out of your pack on a swirl of magic dust.";
        private const string String0BB3 = "It intersects the Rainbow and bursts into blinding light.";
        private const string String0BED = "Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.";
        private const string String0C59 = "A rainbow voyage across the Ageless Void awaits you to the West.";
        private const string String0C9A = "A beam of blue arcs over the Ageless Void.";
        private const string String0CC5 = "A vibrant rainbow of color forms.";
        private const string String0CE7 = "Your miniature Golden Boat floats out of your pack on a swirl of magic dust.";
        private const string String0D34 = "It intersects the Rainbow and bursts into blinding light.";
        private const string String0D6E = "Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.";
        private const string String0DDA = "A rainbow voyage across the Ageless Void awaits you to the West.";
        private const string String0E1B = "This gate leads to the GIANTS' LAND";
        private const string String0E3F = "A burst of moon light floods the room.";
        private const string String0E66 = "Dragons defend their lair.";
        private const string String0E81 = "Rune symbols decorate the tapestry -- ";
        private const string String0EA8 = "Past the Platforms a Tapestry you will find.";
        private const string String0ED5 = "Illuminate the Moons with the Spectrum of the Moon Prism.";
        private const string String0F0F = "Then... ACK, UGH, THUMP  (the rest of the tapestry is smeared with blood)";
        private const string String0F59 = "You step across the platform and into the Golden Boat.";
        private const string String0F90 = "The Zephyr Wind blows the lightest of breezes from the east and the Golden Boat sets sail west across the Rainbow.";
        private const string String1003 = "In the moments that follow the Zephyr tells you only the FlexSword can remain in your hands when you encounter the Wind Elemental.";
        private const string String1086 = "Destroy him and the way to En-li-kil's Domain will be clear.";
        private const string String10C3 = "You arrive at an island in the center of the Ageless Void.";
        private const string String10FE = "The Ageless Void swallows you whole.";
        private const string String1123 = "This door leads the way back to the Land of Giants.";
        private const string String1157 = "This side of the tapestry appears dark.";
        private const string String117F = "You stand upon a platform in the center of the River of Eternity.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => RIVER_01;
        private void RIVER_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // The River of Eternity taps your life energy.
            L0010: UnknownFunctionC4(party);
            L0018: ax = GetMaxHits74(party);
            L001F: bx = 0x0004;
            L0022: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L0025: DoDamage90(party, ax);
            L002F: ax = GetCurrentHits70(party);
            L0036: RefreshCompareFlags(ax);
            L0038: if (result.unsigned_greater_than) goto L0047;
            L003A: ShowMessage(party, String0429); // You have died.
            L0047: // RETURN;
        }

        private override MapEventHandler MapEvent02 => RIVRBANK_02;
        private void RIVRBANK_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0438); // Only the bravest adventurers explore the River for hidden passages.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent03 => VOID_03;
        private void VOID_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String047C); // The Ageless Void swallows you whole.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: // RETURN;
        }

        private override MapEventHandler MapEvent04 => PLATA_04;
        private void PLATA_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String04A1); // SageCross Fountain revives your Health and Mana
            L001D: ax = GetMaxHits74(party);
            L0024: AddHealth94(party, ax);
            L002E: AddMana(party, 0x2EE0);
            L003B: // RETURN;
        }

        private override MapEventHandler MapEvent05 => PLATB_05;
        private void PLATB_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x84);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.notequal) goto L008E;
            L0018: SetState00(party, 0x02, 0x84, 0x01);
            L002D: ShowPortrait(party, 0x0042);
            L003A: ShowMessage(party, String04D1); // DragonBreath Fountain empowers you with improved attributes.
            L0047: ModifyAttributeA8(party, 0x00, 0x0001);
            L0058: ModifyAttributeA8(party, 0x01, 0x0001);
            L006A: ModifyAttributeA8(party, 0x02, 0x0001);
            L007C: ModifyAttributeA8(party, 0x03, 0x0001);
            L008E: // RETURN;
        }

        private override MapEventHandler MapEvent06 => PLATCTOA_06;
        private void PLATCTOA_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String050E); // Minotaur Fountain revives your Health and Mana
            L001D: ax = GetMaxHits74(party);
            L0024: AddHealth94(party, ax);
            L002E: AddMana(party, 0x2EE0);
            L003B: // RETURN;
        }

        private override MapEventHandler MapEvent07 => PLATDTOB_07;
        private void PLATDTOB_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String053D); // As you reach the platform, a magical field envelops you and teleports you to a moon tapestry.
            L0010: SetMoveMap(party, 0x02, 0xEE, 0x03, 0x38);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent0C => TAPMOONS_0C;
        private void TAPMOONS_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xF2, 0xF2);
            L0016: if (result.equal) goto L005F;
            L0018: Push(02);
            L001C: ax = GetNextTile20(party);
            L0023: PushStack(ax);
            L0024: Push(01);
            L0028: SetUnblocked30(party);
            L0032: Push(01);
            L0036: ax = GetFacing24(party);
            L003D: PushStack(ax);
            L003E: ax = GetNextTile20(party);
            L0045: PushStack(ax);
            L0046: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0050: ShowMessage(party, String059B); // A magical door appears where the tapestry used to be.
            L005D: goto L006C;
            L005F: ShowMessage(party, String05D1); // A brilliant tapestry depicting moons decorates this room.
            L006C: // RETURN;
        }

        private override MapEventHandler MapEvent12 => THEFCLUE_12;
        private void THEFCLUE_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0024);
            L0010: ShowMessage(party, String060B); // A Gnome Thief steps out of the shadows -
            L001D: ShowMessage(party, String0634); // 'You are very near the final battle with the Elemental En-Li-Kil.
            L002A: ShowMessage(party, String0676); // The four Rainbow Gems will light your way to the infinite beyond when they are all placed.
            L0037: ShowMessage(party, String06D1); // Red, yellow, green and blue are the rainbow colors.
            L0044: ShowMessage(party, String0705); // Have your boat when the gems are set and sail the rainbow to your destiny.'
            L0051: // RETURN;
        }

        private override MapEventHandler MapEvent13 => THIEVES_13;
        private void THIEVES_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0751); // A doorway is marked -- 'Voranti's Treasure'
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent14 => RAINBOW_14;
        private void RAINBOW_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String077D); // Various golden objects appear to be standing to the west, just at the edge of the Ageless Void.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent15 => RAINRED_15;
        private void RAINRED_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xF4, 0xF4);
            L0016: if (result.notequal) goto L001B;
            L0018: goto L00B5;
            L001B: ShowMessage(party, String07DD); // A beam of red arcs over the Ageless Void.
            L0028: SetState00(party, 0x02, 0x80, 0x01);
            L003D: ax = CheckState04(party, 0x02, 0x80);
            L004E: RefreshCompareFlags(ax);
            L0050: if (result.equal) goto L00B3;
            L0052: ax = CheckState04(party, 0x02, 0x81);
            L0063: RefreshCompareFlags(ax);
            L0065: if (result.equal) goto L00B3;
            L0067: ax = CheckState04(party, 0x02, 0x82);
            L0078: RefreshCompareFlags(ax);
            L007A: if (result.equal) goto L00B3;
            L007C: ax = CheckState04(party, 0x02, 0x83);
            L008D: RefreshCompareFlags(ax);
            L008F: if (result.equal) goto L00B3;
            L0091: SetState00(party, 0x01, 0x01, 0x01);
            L00A6: ShowMessage(party, String0807); // A vibrant rainbow of color forms.
            L00B3: goto L00C2;
            L00B5: ShowMessage(party, String0829); // A golden statue appears to be capable of holding a gem.
            L00C2: ax = UsedItem54(party, 0xF3, 0xF3);
            L00D5: if (result.notequal) goto L00DA;
            L00D7: goto L015A;
            L00DA: ax = CheckState04(party, 0x01, 0x01);
            L00EB: RefreshCompareFlags(ax);
            L00ED: if (result.equal) goto L015A;
            L00EF: SetState00(party, 0x01, 0x01, 0x01);
            L0104: SetMove38(party, 0x75, 0x42);
            L0115: SetMove38(party, 0x85, 0x42);
            L0126: ShowMessage(party, String0861); // Your miniature Golden Boat floats out of your pack on a swirl of magic dust.
            L0133: ShowMessage(party, String08AE); // It intersects the Rainbow and bursts into blinding light.
            L0140: ShowMessage(party, String08E8); // Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.
            L014D: ShowMessage(party, String0954); // A rainbow voyage across the Ageless Void awaits you to the West.
            L015A: // RETURN;
        }

        private override MapEventHandler MapEvent16 => RAINYEL_16;
        private void RAINYEL_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xF5, 0xF5);
            L0016: if (result.notequal) goto L001B;
            L0018: goto L00B3;
            L001B: ShowMessage(party, String0995); // A beam of yellow arcs over the Ageless Void.
            L0028: SetState00(party, 0x02, 0x81, 0x01);
            L003D: ax = CheckState04(party, 0x02, 0x80);
            L004E: RefreshCompareFlags(ax);
            L0050: if (result.equal) goto L00B3;
            L0052: ax = CheckState04(party, 0x02, 0x81);
            L0063: RefreshCompareFlags(ax);
            L0065: if (result.equal) goto L00B3;
            L0067: ax = CheckState04(party, 0x02, 0x82);
            L0078: RefreshCompareFlags(ax);
            L007A: if (result.equal) goto L00B3;
            L007C: ax = CheckState04(party, 0x02, 0x83);
            L008D: RefreshCompareFlags(ax);
            L008F: if (result.equal) goto L00B3;
            L0091: SetState00(party, 0x01, 0x01, 0x01);
            L00A6: ShowMessage(party, String09C2); // A vibrant rainbow of color forms.
            L00B3: ax = UsedItem54(party, 0xF3, 0xF3);
            L00C6: if (result.notequal) goto L00CB;
            L00C8: goto L014B;
            L00CB: ax = CheckState04(party, 0x01, 0x01);
            L00DC: RefreshCompareFlags(ax);
            L00DE: if (result.equal) goto L014B;
            L00E0: SetState00(party, 0x01, 0x01, 0x01);
            L00F5: SetMove38(party, 0x75, 0x42);
            L0106: SetMove38(party, 0x85, 0x42);
            L0117: ShowMessage(party, String09E4); // Your miniature Golden Boat floats out of your pack on a swirl of magic dust.
            L0124: ShowMessage(party, String0A31); // It intersects the Rainbow and bursts into blinding light.
            L0131: ShowMessage(party, String0A6B); // Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.
            L013E: ShowMessage(party, String0AD7); // A rainbow voyage across the Ageless Void awaits you to the West.
            L014B: // RETURN;
        }

        private override MapEventHandler MapEvent17 => RAINGRN_17;
        private void RAINGRN_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xF6, 0xF6);
            L0016: if (result.notequal) goto L001B;
            L0018: goto L00B3;
            L001B: ShowMessage(party, String0B18); // A beam of green arcs over the Ageless Void.
            L0028: SetState00(party, 0x02, 0x82, 0x01);
            L003D: ax = CheckState04(party, 0x02, 0x80);
            L004E: RefreshCompareFlags(ax);
            L0050: if (result.equal) goto L00B3;
            L0052: ax = CheckState04(party, 0x02, 0x81);
            L0063: RefreshCompareFlags(ax);
            L0065: if (result.equal) goto L00B3;
            L0067: ax = CheckState04(party, 0x02, 0x82);
            L0078: RefreshCompareFlags(ax);
            L007A: if (result.equal) goto L00B3;
            L007C: ax = CheckState04(party, 0x02, 0x83);
            L008D: RefreshCompareFlags(ax);
            L008F: if (result.equal) goto L00B3;
            L0091: SetState00(party, 0x01, 0x01, 0x01);
            L00A6: ShowMessage(party, String0B44); // A vibrant rainbow of color forms.
            L00B3: ax = UsedItem54(party, 0xF3, 0xF3);
            L00C6: if (result.notequal) goto L00CB;
            L00C8: goto L014B;
            L00CB: ax = CheckState04(party, 0x01, 0x01);
            L00DC: RefreshCompareFlags(ax);
            L00DE: if (result.equal) goto L014B;
            L00E0: SetState00(party, 0x01, 0x01, 0x01);
            L00F5: SetMove38(party, 0x75, 0x42);
            L0106: SetMove38(party, 0x85, 0x42);
            L0117: ShowMessage(party, String0B66); // Your miniature Golden Boat floats out of your pack on a swirl of magic dust.
            L0124: ShowMessage(party, String0BB3); // It intersects the Rainbow and bursts into blinding light.
            L0131: ShowMessage(party, String0BED); // Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.
            L013E: ShowMessage(party, String0C59); // A rainbow voyage across the Ageless Void awaits you to the West.
            L014B: // RETURN;
        }

        private override MapEventHandler MapEvent18 => RAINBLU_18;
        private void RAINBLU_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xF7, 0xF7);
            L0016: if (result.notequal) goto L001B;
            L0018: goto L00B3;
            L001B: ShowMessage(party, String0C9A); // A beam of blue arcs over the Ageless Void.
            L0028: SetState00(party, 0x02, 0x83, 0x01);
            L003D: ax = CheckState04(party, 0x02, 0x80);
            L004E: RefreshCompareFlags(ax);
            L0050: if (result.equal) goto L00B3;
            L0052: ax = CheckState04(party, 0x02, 0x81);
            L0063: RefreshCompareFlags(ax);
            L0065: if (result.equal) goto L00B3;
            L0067: ax = CheckState04(party, 0x02, 0x82);
            L0078: RefreshCompareFlags(ax);
            L007A: if (result.equal) goto L00B3;
            L007C: ax = CheckState04(party, 0x02, 0x83);
            L008D: RefreshCompareFlags(ax);
            L008F: if (result.equal) goto L00B3;
            L0091: SetState00(party, 0x01, 0x01, 0x01);
            L00A6: ShowMessage(party, String0CC5); // A vibrant rainbow of color forms.
            L00B3: ax = UsedItem54(party, 0xF3, 0xF3);
            L00C6: if (result.notequal) goto L00CB;
            L00C8: goto L014B;
            L00CB: ax = CheckState04(party, 0x01, 0x01);
            L00DC: RefreshCompareFlags(ax);
            L00DE: if (result.equal) goto L014B;
            L00E0: SetState00(party, 0x01, 0x01, 0x01);
            L00F5: SetMove38(party, 0x75, 0x42);
            L0106: SetMove38(party, 0x85, 0x42);
            L0117: ShowMessage(party, String0CE7); // Your miniature Golden Boat floats out of your pack on a swirl of magic dust.
            L0124: ShowMessage(party, String0D34); // It intersects the Rainbow and bursts into blinding light.
            L0131: ShowMessage(party, String0D6E); // Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.
            L013E: ShowMessage(party, String0DDA); // A rainbow voyage across the Ageless Void awaits you to the West.
            L014B: // RETURN;
        }

        private override MapEventHandler MapEvent19 => GATEA_19;
        private void GATEA_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E1B); // This gate leads to the GIANTS' LAND
            L0010: SetMoveMap(party, 0x03, 0xFB, 0x02, 0x38);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent1A => ENCA_1A;
        private void ENCA_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E3F); // A burst of moon light floods the room.
            L0010: AddEncounter(party, 0x24, 0x01);
            L0022: AddEncounter(party, 0x24, 0x02);
            L0034: AddEncounter(party, 0x25, 0x03);
            L0046: AddEncounter(party, 0x25, 0x04);
            L0058: AddEncounter(party, 0x22, 0x05);
            L006A: AddEncounter(party, 0x22, 0x06);
            L007C: // RETURN;
        }

        private override MapEventHandler MapEvent1B => ENCB_1B;
        private void ENCB_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x26, 0x01);
            L0015: AddEncounter(party, 0x27, 0x02);
            L0027: AddEncounter(party, 0x1A, 0x03);
            L0039: AddEncounter(party, 0x1C, 0x04);
            L004B: AddEncounter(party, 0x1E, 0x05);
            L005D: // RETURN;
        }

        private override MapEventHandler MapEvent1C => ENCC_1C;
        private void ENCC_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E66); // Dragons defend their lair.
            L0010: AddEncounter(party, 0x26, 0x01);
            L0022: AddEncounter(party, 0x28, 0x02);
            L0034: AddEncounter(party, 0x17, 0x05);
            L0046: AddEncounter(party, 0x17, 0x06);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent1D => ENCD_1D;
        private void ENCD_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x19, 0x01);
            L0015: AddEncounter(party, 0x19, 0x02);
            L0027: AddEncounter(party, 0x1B, 0x03);
            L0039: AddEncounter(party, 0x1B, 0x04);
            L004B: AddEncounter(party, 0x22, 0x05);
            L005D: AddEncounter(party, 0x23, 0x06);
            L006F: // RETURN;
        }

        private override MapEventHandler MapEvent1E => TAPECLUE_1E;
        private void TAPECLUE_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E81); // Rune symbols decorate the tapestry -- 
            L0010: ShowRunes(party, String0EA8); // Past the Platforms a Tapestry you will find.
            L001D: ShowRunes(party, String0ED5); // Illuminate the Moons with the Spectrum of the Moon Prism.
            L002A: ShowRunes(party, String0F0F); // Then... ACK, UGH, THUMP  (the rest of the tapestry is smeared with blood)
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent1F => BOAT_1F;
        private void BOAT_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x01);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.equal) goto L0075;
            L0018: ShowMessage(party, String0F59); // You step across the platform and into the Golden Boat.
            L0025: ShowMessage(party, String0F90); // The Zephyr Wind blows the lightest of breezes from the east and the Golden Boat sets sail west across the Rainbow.
            L0032: ShowMessage(party, String1003); // In the moments that follow the Zephyr tells you only the FlexSword can remain in your hands when you encounter the Wind Elemental.
            L003F: ShowMessage(party, String1086); // Destroy him and the way to En-li-kil's Domain will be clear.
            L004C: ShowMessage(party, String10C3); // You arrive at an island in the center of the Ageless Void.
            L0059: SetMoveMap(party, 0x00, 0x4B, 0x04, 0x38);
            L0073: goto L0093;
            L0075: ShowMessage(party, String10FE); // The Ageless Void swallows you whole.
            L0082: ax = GetMaxHits74(party);
            L0089: DoDamage90(party, ax);
            L0093: // RETURN;
        }

        private override MapEventHandler MapEvent20 => DOORWARN_20;
        private void DOORWARN_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1123); // This door leads the way back to the Land of Giants.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent24 => NOLIGHT_24;
        private void NOLIGHT_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1157); // This side of the tapestry appears dark.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent25 => PLATFORM_25;
        private void PLATFORM_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String117F); // You stand upon a platform in the center of the River of Eternity.
            L0010: // RETURN;
        }

    }
}
