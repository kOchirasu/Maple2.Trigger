using Maple2.Trigger.Enum;

namespace Maple2.Trigger._61000007_me {
    public static class _mainprocess_springbeach {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{302})) {
                    return new State이벤트Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이벤트Waiting : TriggerState {
            internal State이벤트Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 901, visible: true, enabled: true, minimapVisible: true);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: false);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624}, visible: false);
                context.SetMesh(triggerIds: new []{651, 652, 653, 654, 655, 656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 670, 671, 672, 673, 674, 675, 676, 677}, visible: true);
                context.SetMesh(triggerIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733, 734, 735, 736, 737, 738, 739, 740, 741, 742, 743, 744, 745, 746, 747, 748, 749, 750, 751, 752, 753, 754, 755, 756, 757, 758, 759, 760, 761, 762, 763, 764, 765, 766, 767, 768, 769, 770, 771, 772, 773, 774, 775, 776, 777, 778, 779, 780, 781, 782, 783, 784, 785, 786, 787, 788, 789, 790, 791, 792, 793, 794, 795, 796, 797, 798, 799, 800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832}, visible: true);
                context.SetEffect(triggerIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528, 529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 302) == 50) {
                    return new StateSetupMassiveEvent1(context);
                }

                if (context.WaitTick(waitTick: 60000)) {
                    return new StateSetupMassiveEvent1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupMassiveEvent1 : TriggerState {
            internal StateSetupMassiveEvent1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 6);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_00");
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__0$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new StateSetupMassiveEvent2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupMassiveEvent2 : TriggerState {
            internal StateSetupMassiveEvent2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 4);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_01");
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__1$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new State경기장입장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경기장입장 : TriggerState {
            internal State경기장입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                context.MoveUser(mapId: 61000007, portalId: 902, boxId: 302);
                    return new StateWait(context);
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "13", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "13")) {
                    return new StateStartMassiveEvent1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartMassiveEvent1 : TriggerState {
            internal StateStartMassiveEvent1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGame(boxId: 301, round: 5, type: MiniGame.SpringBeach);
                context.SetMiniGameAreaForHack(boxId: 301);
                context.SetTimer(timerId: "13", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__2$", duration: 4000);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_02");
                context.SetAchievement(triggerId: 301, type: "trigger", code: "springbeach_start");
                context.SetAchievement(triggerId: 301, type: "trigger", code: "dailyquest_start");
                context.GiveGuildExp(boxId: 0, type: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "13")) {
                    return new StateStartMassiveEvent2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartMassiveEvent2 : TriggerState {
            internal StateStartMassiveEvent2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "14", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__3$", duration: 5500);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_03");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "14")) {
                    return new StateStartMassiveEvent3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartMassiveEvent3 : TriggerState {
            internal StateStartMassiveEvent3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_04");
                context.SetTimer(timerId: "15", seconds: 7);
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__4$", duration: 7000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State라운드1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드1 : TriggerState {
            internal State라운드1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 301, round: 1);
                context.SetTimer(timerId: "16", seconds: 4);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_05");
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__5$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "16")) {
                    return new State게임시작1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작1 : TriggerState {
            internal State게임시작1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "17", seconds: 6);
                context.SetEventUI(arg1: 0, script: "1,5");
                context.ShowCountUI(text: "$61000007_ME__MAINPROCESS_SPRINGBEACH__6$", stage: 1, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "17")) {
                    return new State스프링섞기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스프링섞기01 : TriggerState {
            internal State스프링섞기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 5f)) {
                    return new State1스프링공격01(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State1스프링공격02(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State1스프링공격03(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State1스프링공격04(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State1스프링공격05(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State1스프링공격06(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State1스프링공격07(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State1스프링공격08(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State1스프링공격09(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State1스프링공격10(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State1스프링공격11(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State1스프링공격12(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State1스프링공격13(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State1스프링공격14(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State1스프링공격15(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State1스프링공격16(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State1스프링공격17(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State1스프링공격18(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State1스프링공격19(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State1스프링공격20(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격21(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격22(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격23(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격24(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격25(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격26(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격27(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격28(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격29(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격30(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격31(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격32(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격33(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격34(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격35(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격36(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격37(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격38(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격39(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State1스프링공격40(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격중지01 : TriggerState {
            internal State공격중지01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "19", seconds: 3);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "19")) {
                    return new State생존자수색01(context);
                }

                if (!context.UserDetected(boxIds: new []{301})) {
                    return new State모두탈락(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존자수색01 : TriggerState {
            internal State생존자수색01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    return new State한숨돌리기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State한숨돌리기01 : TriggerState {
            internal State한숨돌리기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301, expRate: 0.2f);
                context.SetTimer(timerId: "20", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new State라운드2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드2 : TriggerState {
            internal State라운드2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 301, round: 2);
                context.SetTimer(timerId: "21", seconds: 4);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_07");
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__7$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "21")) {
                    return new State게임시작2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작2 : TriggerState {
            internal State게임시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "22", seconds: 6);
                context.SetEventUI(arg1: 0, script: "2,5");
                context.ShowCountUI(text: "$61000007_ME__MAINPROCESS_SPRINGBEACH__8$", stage: 2, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "22")) {
                    return new State스프링섞기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스프링섞기02 : TriggerState {
            internal State스프링섞기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 2f)) {
                    return new State2스프링공격01(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State2스프링공격02(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State2스프링공격03(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State2스프링공격04(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State2스프링공격05(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State2스프링공격06(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State2스프링공격07(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State2스프링공격08(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State2스프링공격09(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State2스프링공격10(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State2스프링공격11(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State2스프링공격12(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State2스프링공격13(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State2스프링공격14(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State2스프링공격15(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State2스프링공격16(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State2스프링공격17(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State2스프링공격18(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State2스프링공격19(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State2스프링공격20(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격21(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격22(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격23(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격24(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격25(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State2스프링공격26(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State2스프링공격27(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State2스프링공격28(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State2스프링공격29(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State2스프링공격30(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격31(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격32(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격33(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격34(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격35(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격36(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격37(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격38(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격39(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State2스프링공격40(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격중지02 : TriggerState {
            internal State공격중지02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "23", seconds: 3);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "23")) {
                    return new State생존자수색02(context);
                }

                if (!context.UserDetected(boxIds: new []{301})) {
                    return new State모두탈락(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존자수색02 : TriggerState {
            internal State생존자수색02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    return new State한숨돌리기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State한숨돌리기02 : TriggerState {
            internal State한숨돌리기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301, expRate: 0.2f);
                context.SetTimer(timerId: "24", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "24")) {
                    return new State라운드3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드3 : TriggerState {
            internal State라운드3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 301, round: 3);
                context.SetTimer(timerId: "25", seconds: 4);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_09");
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__9$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "25")) {
                    return new State게임시작3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작3 : TriggerState {
            internal State게임시작3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "26", seconds: 6);
                context.SetEventUI(arg1: 0, script: "3,5");
                context.ShowCountUI(text: "$61000007_ME__MAINPROCESS_SPRINGBEACH__10$", stage: 3, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "26")) {
                    return new State스프링섞기03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스프링섞기03 : TriggerState {
            internal State스프링섞기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격01(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격02(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격03(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격04(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격05(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격06(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격07(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격08(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격09(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격10(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격11(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격12(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격13(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격14(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State3스프링공격15(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State3스프링공격16(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State3스프링공격17(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State3스프링공격18(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State3스프링공격19(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State3스프링공격20(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3스프링공격21(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3스프링공격22(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3스프링공격23(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3스프링공격24(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3스프링공격25(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State3스프링공격26(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State3스프링공격27(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State3스프링공격28(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State3스프링공격29(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State3스프링공격30(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State3스프링공격31(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State3스프링공격32(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State3스프링공격33(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State3스프링공격34(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State3스프링공격35(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3스프링공격36(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3스프링공격37(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3스프링공격38(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3스프링공격39(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State3스프링공격40(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격중지03 : TriggerState {
            internal State공격중지03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "27", seconds: 3);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "27")) {
                    return new State생존자수색03(context);
                }

                if (!context.UserDetected(boxIds: new []{301})) {
                    return new State모두탈락(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존자수색03 : TriggerState {
            internal State생존자수색03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    return new State한숨돌리기03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State한숨돌리기03 : TriggerState {
            internal State한숨돌리기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301, expRate: 0.2f);
                context.SetTimer(timerId: "28", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "28")) {
                    return new State라운드4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드4 : TriggerState {
            internal State라운드4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 301, round: 4);
                context.SetTimer(timerId: "29", seconds: 4);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_11");
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__11$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "29")) {
                    return new State게임시작4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작4 : TriggerState {
            internal State게임시작4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 6);
                context.SetEventUI(arg1: 0, script: "4,5");
                context.ShowCountUI(text: "$61000007_ME__MAINPROCESS_SPRINGBEACH__12$", stage: 4, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new State스프링섞기04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스프링섞기04 : TriggerState {
            internal State스프링섞기04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격01(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격02(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격03(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격04(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격05(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격06(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격07(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격08(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격09(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격10(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격11(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격12(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격13(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격14(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State4스프링공격15(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격16(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격17(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격18(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격19(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격20(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격21(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격22(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격23(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격24(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격25(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격26(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격27(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격28(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격29(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격30(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격31(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격32(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격33(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격34(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격35(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State4스프링공격36(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격37(context);
                }

                if (context.RandomCondition(rate: 3f)) {
                    return new State4스프링공격38(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격39(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State4스프링공격40(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격중지04 : TriggerState {
            internal State공격중지04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "31", seconds: 3);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "31")) {
                    return new State생존자수색04(context);
                }

                if (!context.UserDetected(boxIds: new []{301})) {
                    return new State모두탈락(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존자수색04 : TriggerState {
            internal State생존자수색04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    return new State한숨돌리기04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State한숨돌리기04 : TriggerState {
            internal State한숨돌리기04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301, expRate: 0.2f);
                context.SetTimer(timerId: "32", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "32")) {
                    return new State라운드5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드5 : TriggerState {
            internal State라운드5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 301, round: 5);
                context.SetTimer(timerId: "33", seconds: 4);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_13");
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__13$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "33")) {
                    return new State게임시작5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작5 : TriggerState {
            internal State게임시작5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "34", seconds: 6);
                context.SetEventUI(arg1: 0, script: "5,5");
                context.ShowCountUI(text: "$61000007_ME__MAINPROCESS_SPRINGBEACH__14$", stage: 5, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "34")) {
                    return new State스프링섞기05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스프링섞기05 : TriggerState {
            internal State스프링섞기05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 2f)) {
                    return new State5스프링공격16(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State5스프링공격17(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State5스프링공격18(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State5스프링공격19(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State5스프링공격20(context);
                }

                if (context.RandomCondition(rate: 6f)) {
                    return new State5스프링공격21(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State5스프링공격22(context);
                }

                if (context.RandomCondition(rate: 6f)) {
                    return new State5스프링공격23(context);
                }

                if (context.RandomCondition(rate: 6f)) {
                    return new State5스프링공격24(context);
                }

                if (context.RandomCondition(rate: 6f)) {
                    return new State5스프링공격25(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State5스프링공격26(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State5스프링공격27(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State5스프링공격28(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State5스프링공격29(context);
                }

                if (context.RandomCondition(rate: 2f)) {
                    return new State5스프링공격30(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State5스프링공격31(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State5스프링공격32(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State5스프링공격33(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State5스프링공격34(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State5스프링공격35(context);
                }

                if (context.RandomCondition(rate: 4f)) {
                    return new State5스프링공격36(context);
                }

                if (context.RandomCondition(rate: 6f)) {
                    return new State5스프링공격37(context);
                }

                if (context.RandomCondition(rate: 6f)) {
                    return new State5스프링공격38(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State5스프링공격39(context);
                }

                if (context.RandomCondition(rate: 5f)) {
                    return new State5스프링공격40(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State공격중지05 : TriggerState {
            internal State공격중지05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "35", seconds: 3);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "35")) {
                    return new State생존자수색05(context);
                }

                if (!context.UserDetected(boxIds: new []{301})) {
                    return new State모두탈락(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생존자수색05 : TriggerState {
            internal State생존자수색05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    return new State한숨돌리기05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State한숨돌리기05 : TriggerState {
            internal State한숨돌리기05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301, expRate: 0.2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State우승자CameraCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우승자CameraCinematic : TriggerState {
            internal State우승자CameraCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MiniGameCameraDirection(boxId: 301, cameraId: 9001);
                context.PlaySystemSoundInBox(boxIds: new []{301}, sound: "ME_Mainprocess_Springbeach_15");
                context.SetEventUI(arg1: 3, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__15$", duration: 5000, boxId: 301);
                context.SetEventUI(arg1: 6, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__16$", duration: 5000, boxId: 303);
                context.SetEventUI(arg1: 6, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__16$", duration: 5000, boxId: 304);
                context.SetEventUI(arg1: 6, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__16$", duration: 5000, boxId: 305);
                context.SetEventUI(arg1: 6, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__16$", duration: 5000, boxId: 306);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetLocalCamera(cameraId: 9001, enable: false);
                    return new State보상단계(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보상단계 : TriggerState {
            internal State보상단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 3, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__17$", duration: 5000, boxId: 301);
                context.SetEventUI(arg1: 6, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__18$", duration: 5000, boxId: 303);
                context.SetEventUI(arg1: 6, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__18$", duration: 5000, boxId: 304);
                context.SetEventUI(arg1: 6, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__18$", duration: 5000, boxId: 305);
                context.SetEventUI(arg1: 6, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__18$", duration: 5000, boxId: 306);
                context.AddBuff(boxIds: new []{301}, skillId: 70000019, level: 1);
                context.SetAchievement(triggerId: 301, type: "trigger", code: "springbeach_win");
                context.MiniGameGiveReward(winnerBoxId: 301, contentType: "miniGame");
                context.EndMiniGame(winnerBoxId: 301, type: MiniGame.SpringBeach);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State다리Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State모두탈락 : TriggerState {
            internal State모두탈락(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301);
                context.EndMiniGame(winnerBoxId: 301, type: MiniGame.SpringBeach);
                context.SetTimer(timerId: "40", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "40")) {
                    return new State탈락MassiveEvent(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈락MassiveEvent : TriggerState {
            internal State탈락MassiveEvent(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "40", seconds: 6);
                context.SetEventUI(arg1: 5, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__21$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "40")) {
                    return new State다리Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Spawn : TriggerState {
            internal State다리Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.UnSetMiniGameAreaForHack();
                context.SetTimer(timerId: "41", seconds: 10);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624}, visible: true);
                context.SetMesh(triggerIds: new []{651, 652, 653, 654, 655, 656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 670, 671, 672, 673, 674, 675, 676, 677}, visible: false);
                context.SetMesh(triggerIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733, 734, 735, 736, 737, 738, 739, 740, 741, 742, 743, 744, 745, 746, 747, 748, 749, 750, 751, 752, 753, 754, 755, 756, 757, 758, 759, 760, 761, 762, 763, 764, 765, 766, 767, 768, 769, 770, 771, 772, 773, 774, 775, 776, 777, 778, 779, 780, 781, 782, 783, 784, 785, 786, 787, 788, 789, 790, 791, 792, 793, 794, 795, 796, 797, 798, 799, 800, 801, 802, 803, 804, 805, 806, 807, 808, 809, 810, 811, 812, 813, 814, 815, 816, 817, 818, 819, 820, 821, 822, 823, 824, 825, 826, 827, 828, 829, 830, 831, 832}, visible: false);
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__22$", duration: 10000);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_22");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "41")) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000007_ME__MAINPROCESS_SPRINGBEACH__23$", duration: 5000, boxId: 0);
                context.PlaySystemSoundInBox(sound: "ME_Mainprocess_Springbeach_23");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 120000)) {
                    context.MoveUser(mapId: 0, portalId: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격01 : TriggerState {
            internal State1스프링공격01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{105, 106, 107, 108, 117, 118, 119, 120, 129, 130, 131, 132, 137, 138, 139, 140, 141, 142, 143, 144, 145, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{205, 206, 207, 208, 217, 218, 219, 220, 229, 230, 231, 232, 237, 238, 239, 240, 241, 242, 243, 244, 245, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_01게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_01게임진행1 : TriggerState {
            internal State1_01게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격02 : TriggerState {
            internal State1스프링공격02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 137, 138, 139, 140, 150, 151, 152, 153}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 237, 238, 239, 240, 250, 251, 252, 253}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_02게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_02게임진행1 : TriggerState {
            internal State1_02게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격03 : TriggerState {
            internal State1스프링공격03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 109, 110, 111, 112, 113, 114, 115, 116, 121, 122, 123, 124, 129, 130, 131, 132, 141, 142, 143, 144, 145, 154, 155, 156, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 209, 210, 211, 212, 213, 214, 215, 216, 221, 222, 223, 224, 229, 230, 231, 232, 241, 242, 243, 244, 245, 254, 255, 256, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_03게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_03게임진행1 : TriggerState {
            internal State1_03게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격04 : TriggerState {
            internal State1스프링공격04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{107, 117, 118, 119, 120, 121, 127, 128, 129, 133, 134, 135, 137, 138, 139, 147, 148, 149, 150, 151, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{207, 217, 218, 219, 220, 221, 227, 228, 229, 233, 234, 235, 237, 238, 239, 247, 248, 249, 250, 251, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_04게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_04게임진행1 : TriggerState {
            internal State1_04게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격05 : TriggerState {
            internal State1스프링공격05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{104, 105, 108, 109, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 140, 141, 145, 146, 153, 154, 160, 161}, enabled: true);
                context.SetSkill(triggerIds: new []{204, 205, 208, 209, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 240, 241, 245, 246, 253, 254, 260, 261}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_05게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_05게임진행1 : TriggerState {
            internal State1_05게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격06 : TriggerState {
            internal State1스프링공격06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 120, 121, 128, 129, 131, 132, 133, 142, 143, 144, 145, 146, 155, 156, 157, 158, 159, 160, 161}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 220, 221, 228, 229, 231, 232, 233, 242, 243, 244, 245, 246, 255, 256, 257, 258, 259, 260, 261}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_06게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_06게임진행1 : TriggerState {
            internal State1_06게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격07 : TriggerState {
            internal State1스프링공격07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 111, 112, 115, 116, 117, 118, 119, 120, 121, 122, 127, 128, 129, 130, 131, 132, 133, 134, 137, 138, 143, 148, 149, 150, 151, 156, 157, 158, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 211, 212, 215, 216, 217, 218, 219, 220, 221, 222, 227, 228, 229, 230, 231, 232, 233, 234, 237, 238, 243, 248, 249, 250, 251, 256, 257, 258, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_07게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_07게임진행1 : TriggerState {
            internal State1_07게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격08 : TriggerState {
            internal State1스프링공격08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 131, 132, 133, 134, 135, 136, 138, 139, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 155, 156}, enabled: true);
                context.SetSkill(triggerIds: new []{207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 231, 232, 233, 234, 235, 236, 238, 239, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 255, 256}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_08게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_08게임진행1 : TriggerState {
            internal State1_08게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격09 : TriggerState {
            internal State1스프링공격09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 112, 113, 115, 116, 117, 118, 119, 122, 124, 125, 127, 130, 131, 132, 133, 134, 136, 137, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 212, 213, 215, 216, 217, 218, 219, 222, 224, 225, 227, 230, 231, 232, 233, 234, 236, 237, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_09게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_09게임진행1 : TriggerState {
            internal State1_09게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격10 : TriggerState {
            internal State1스프링공격10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 106, 107, 110, 111, 112, 113, 114, 115, 118, 131, 134, 135, 136, 137, 138, 139, 142, 143, 144, 147, 148, 149, 150, 151, 152, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 206, 207, 210, 211, 212, 213, 214, 215, 218, 231, 234, 235, 236, 237, 238, 239, 242, 243, 244, 247, 248, 249, 250, 251, 252, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_10게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_10게임진행1 : TriggerState {
            internal State1_10게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격11 : TriggerState {
            internal State1스프링공격11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 112, 113, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 136, 137, 140, 141, 145, 146, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 212, 213, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 236, 237, 240, 241, 245, 246, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_11게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_11게임진행1 : TriggerState {
            internal State1_11게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격12 : TriggerState {
            internal State1스프링공격12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 107, 108, 113, 114, 115, 116, 119, 120, 125, 126, 127, 128, 131, 132, 138, 140, 142, 146, 147, 148, 149, 151, 153, 155, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 207, 208, 213, 214, 215, 216, 219, 220, 225, 226, 227, 228, 231, 232, 238, 240, 242, 246, 247, 248, 249, 251, 253, 255, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_12게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_12게임진행1 : TriggerState {
            internal State1_12게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격13 : TriggerState {
            internal State1스프링공격13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 105, 107, 109, 111, 113, 115, 117, 119, 121, 123, 125, 127, 129, 131, 133, 135, 137, 139, 141, 143, 145, 147, 149, 151, 153, 155, 157, 159, 161, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 205, 207, 209, 211, 213, 215, 217, 219, 221, 223, 225, 227, 229, 231, 233, 235, 237, 239, 241, 243, 245, 247, 249, 251, 253, 255, 257, 259, 261, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_13게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_13게임진행1 : TriggerState {
            internal State1_13게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격14 : TriggerState {
            internal State1스프링공격14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 106, 108, 109, 111, 114, 116, 117, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 132, 133, 135, 138, 139, 142, 143, 145, 146, 148, 150, 153, 154, 157, 159, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 206, 208, 209, 211, 214, 216, 217, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 232, 233, 235, 238, 239, 242, 243, 245, 246, 248, 250, 253, 254, 257, 259, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_14게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_14게임진행1 : TriggerState {
            internal State1_14게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격15 : TriggerState {
            internal State1스프링공격15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 105, 106, 109, 110, 111, 112, 115, 116, 117, 118, 119, 120, 123, 124, 125, 126, 127, 128, 131, 132, 133, 134, 137, 138, 140, 141, 143, 144, 145, 148, 149, 151, 153, 154, 156, 157, 158, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 205, 206, 209, 210, 211, 212, 215, 216, 217, 218, 219, 220, 223, 224, 225, 226, 227, 228, 231, 232, 233, 234, 237, 238, 240, 241, 243, 244, 245, 248, 249, 251, 253, 254, 256, 257, 258, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_15게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_15게임진행1 : TriggerState {
            internal State1_15게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격16 : TriggerState {
            internal State1스프링공격16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 140, 141, 145, 146, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 240, 241, 245, 246, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_16게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_16게임진행1 : TriggerState {
            internal State1_16게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격17 : TriggerState {
            internal State1스프링공격17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 116, 119, 120, 121, 122, 125, 126, 127, 128, 129, 130, 131, 132, 135, 136, 138, 139, 140, 142, 143, 146, 147, 148, 149, 151, 152, 153, 155, 156, 157, 158, 159, 160, 161, 162}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 211, 212, 213, 214, 215, 216, 219, 220, 221, 222, 225, 226, 227, 228, 229, 230, 231, 232, 235, 236, 238, 239, 240, 242, 243, 246, 247, 248, 249, 251, 252, 253, 255, 256, 257, 258, 259, 260, 261, 262}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_17게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_17게임진행1 : TriggerState {
            internal State1_17게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격18 : TriggerState {
            internal State1스프링공격18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 104, 105, 106, 107, 109, 110, 111, 113, 114, 116, 117, 118, 119, 121, 122, 123, 125, 126, 128, 129, 130, 131, 133, 134, 135, 138, 140, 142, 144, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 204, 205, 206, 207, 209, 210, 211, 213, 214, 216, 217, 218, 219, 221, 222, 223, 225, 226, 228, 229, 230, 231, 233, 234, 235, 238, 240, 242, 244, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_18게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_18게임진행1 : TriggerState {
            internal State1_18게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격19 : TriggerState {
            internal State1스프링공격19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 138, 139, 142, 143, 144, 145, 146, 147, 148, 150, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 238, 239, 242, 243, 244, 245, 246, 247, 248, 250, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_19게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_19게임진행1 : TriggerState {
            internal State1_19게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격20 : TriggerState {
            internal State1스프링공격20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 105, 106, 107, 108, 109, 110, 111, 112, 115, 116, 117, 118, 119, 121, 122, 123, 124, 125, 126, 127, 129, 130, 131, 132, 133, 134, 137, 138, 140, 141, 143, 144, 145, 146, 147, 148, 149, 150, 151, 153, 154, 156, 157, 158, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 205, 206, 207, 208, 209, 210, 211, 212, 215, 216, 217, 218, 219, 221, 222, 223, 224, 225, 226, 227, 229, 230, 231, 232, 233, 234, 237, 238, 240, 241, 243, 244, 245, 246, 247, 248, 249, 250, 251, 253, 254, 256, 257, 258, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_20게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_20게임진행1 : TriggerState {
            internal State1_20게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격21 : TriggerState {
            internal State1스프링공격21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 111, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 140, 141, 143, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 211, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 240, 241, 243, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_21게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_21게임진행1 : TriggerState {
            internal State1_21게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격22 : TriggerState {
            internal State1스프링공격22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113, 114, 115, 116, 118, 119, 120, 121, 122, 123, 125, 126, 127, 128, 129, 130, 131, 132, 134, 135, 136, 138, 139, 140, 141, 142, 143, 145, 146, 147, 148, 149, 150, 151, 152, 153, 155, 156, 157, 158, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 211, 212, 213, 214, 215, 216, 218, 219, 220, 221, 222, 223, 225, 226, 227, 228, 229, 230, 231, 232, 234, 235, 236, 238, 239, 240, 241, 242, 243, 245, 246, 247, 248, 249, 250, 251, 252, 253, 255, 256, 257, 258, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_22게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_22게임진행1 : TriggerState {
            internal State1_22게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격23 : TriggerState {
            internal State1스프링공격23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_23게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_23게임진행1 : TriggerState {
            internal State1_23게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격24 : TriggerState {
            internal State1스프링공격24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 138, 139, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 238, 239, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_24게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_24게임진행1 : TriggerState {
            internal State1_24게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격25 : TriggerState {
            internal State1스프링공격25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 113, 114, 115, 116, 117, 118, 119, 120, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 144, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 215, 216, 217, 218, 219, 220, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 239, 240, 241, 242, 244, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_25게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_25게임진행1 : TriggerState {
            internal State1_25게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격26 : TriggerState {
            internal State1스프링공격26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 115, 116, 119, 120, 122, 124, 125, 127, 129, 130, 132, 133, 135, 136, 137, 138, 139, 142, 143, 144, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 215, 216, 219, 220, 222, 224, 225, 227, 229, 230, 232, 233, 235, 236, 237, 238, 239, 242, 243, 244, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_26게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_26게임진행1 : TriggerState {
            internal State1_26게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격27 : TriggerState {
            internal State1스프링공격27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113, 114, 116, 117, 120, 121, 122, 123, 124, 125, 126, 127, 130, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 210, 211, 212, 213, 214, 216, 217, 220, 221, 222, 223, 224, 225, 226, 227, 230, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_27게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_27게임진행1 : TriggerState {
            internal State1_27게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격28 : TriggerState {
            internal State1스프링공격28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 110, 111, 112, 113, 116, 118, 119, 120, 122, 123, 126, 127, 129, 130, 131, 133, 136, 137, 139, 140, 142, 145, 146, 147, 148, 149, 150, 151, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 210, 211, 212, 213, 216, 218, 219, 220, 222, 223, 226, 227, 229, 230, 231, 233, 236, 237, 239, 240, 242, 245, 246, 247, 248, 249, 250, 251, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_28게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_28게임진행1 : TriggerState {
            internal State1_28게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격29 : TriggerState {
            internal State1스프링공격29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 109, 110, 112, 113, 115, 117, 118, 119, 120, 122, 124, 125, 127, 129, 130, 131, 132, 134, 136, 137, 138, 143, 146, 147, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 209, 210, 212, 213, 215, 217, 218, 219, 220, 222, 224, 225, 227, 229, 230, 231, 232, 234, 236, 237, 238, 243, 246, 247, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_29게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_29게임진행1 : TriggerState {
            internal State1_29게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격30 : TriggerState {
            internal State1스프링공격30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 112, 113, 114, 115, 116, 117, 119, 121, 122, 123, 124, 125, 126, 127, 129, 130, 131, 132, 133, 135, 136, 137, 139, 140, 141, 142, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 212, 213, 214, 215, 216, 217, 219, 221, 222, 223, 224, 225, 226, 227, 229, 230, 231, 232, 233, 235, 236, 237, 239, 240, 241, 242, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_30게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_30게임진행1 : TriggerState {
            internal State1_30게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격31 : TriggerState {
            internal State1스프링공격31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 113, 115, 116, 117, 118, 119, 120, 121, 123, 124, 125, 126, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 213, 215, 216, 217, 218, 219, 220, 221, 223, 224, 225, 226, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_31게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_31게임진행1 : TriggerState {
            internal State1_31게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격32 : TriggerState {
            internal State1스프링공격32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 131, 132, 133, 134, 135, 136, 137, 138, 140, 141, 143, 144, 145, 146, 147, 148, 149, 150, 152, 153, 154, 155, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 231, 232, 233, 234, 235, 236, 237, 238, 240, 241, 243, 244, 245, 246, 247, 248, 249, 250, 252, 253, 254, 255, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_32게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_32게임진행1 : TriggerState {
            internal State1_32게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격33 : TriggerState {
            internal State1스프링공격33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 105, 106, 107, 108, 109, 111, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 156, 157, 158, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 205, 206, 207, 208, 209, 211, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 256, 257, 258, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_33게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_33게임진행1 : TriggerState {
            internal State1_33게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격34 : TriggerState {
            internal State1스프링공격34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 125, 126, 127, 128, 130, 131, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 210, 211, 212, 213, 214, 216, 218, 219, 221, 222, 223, 224, 225, 226, 227, 228, 230, 231, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_34게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_34게임진행1 : TriggerState {
            internal State1_34게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격35 : TriggerState {
            internal State1스프링공격35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 116, 117, 118, 122, 123, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 139, 140, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 216, 217, 218, 222, 223, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 239, 240, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_35게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_35게임진행1 : TriggerState {
            internal State1_35게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격36 : TriggerState {
            internal State1스프링공격36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 153, 154, 155, 156, 158, 159, 160, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 253, 254, 255, 256, 258, 259, 260, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_36게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_36게임진행1 : TriggerState {
            internal State1_36게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격37 : TriggerState {
            internal State1스프링공격37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_37게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_37게임진행1 : TriggerState {
            internal State1_37게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격38 : TriggerState {
            internal State1스프링공격38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_38게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_38게임진행1 : TriggerState {
            internal State1_38게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격39 : TriggerState {
            internal State1스프링공격39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 130, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 144, 145, 146, 147, 149, 150, 151, 152, 153, 154, 155, 156, 158, 159, 160, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 230, 232, 233, 235, 236, 237, 238, 239, 240, 241, 242, 244, 245, 246, 247, 249, 250, 251, 252, 253, 254, 255, 256, 258, 259, 260, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_39게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_39게임진행1 : TriggerState {
            internal State1_39게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1스프링공격40 : TriggerState {
            internal State1스프링공격40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 113, 114, 116, 117, 119, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 216, 217, 219, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State1_40게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1_40게임진행1 : TriggerState {
            internal State1_40게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격01 : TriggerState {
            internal State2스프링공격01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{105, 106, 107, 108, 117, 118, 119, 120, 129, 130, 131, 132, 137, 138, 139, 140, 141, 142, 143, 144, 145, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{205, 206, 207, 208, 217, 218, 219, 220, 229, 230, 231, 232, 237, 238, 239, 240, 241, 242, 243, 244, 245, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_01게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_01게임진행1 : TriggerState {
            internal State2_01게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격02 : TriggerState {
            internal State2스프링공격02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 137, 138, 139, 140, 150, 151, 152, 153}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 237, 238, 239, 240, 250, 251, 252, 253}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_02게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_02게임진행1 : TriggerState {
            internal State2_02게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격03 : TriggerState {
            internal State2스프링공격03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 109, 110, 111, 112, 113, 114, 115, 116, 121, 122, 123, 124, 129, 130, 131, 132, 141, 142, 143, 144, 145, 154, 155, 156, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 209, 210, 211, 212, 213, 214, 215, 216, 221, 222, 223, 224, 229, 230, 231, 232, 241, 242, 243, 244, 245, 254, 255, 256, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_03게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_03게임진행1 : TriggerState {
            internal State2_03게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격04 : TriggerState {
            internal State2스프링공격04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{107, 117, 118, 119, 120, 121, 127, 128, 129, 133, 134, 135, 137, 138, 139, 147, 148, 149, 150, 151, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{207, 217, 218, 219, 220, 221, 227, 228, 229, 233, 234, 235, 237, 238, 239, 247, 248, 249, 250, 251, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_04게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_04게임진행1 : TriggerState {
            internal State2_04게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격05 : TriggerState {
            internal State2스프링공격05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{104, 105, 108, 109, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 140, 141, 145, 146, 153, 154, 160, 161}, enabled: true);
                context.SetSkill(triggerIds: new []{204, 205, 208, 209, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 240, 241, 245, 246, 253, 254, 260, 261}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_05게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_05게임진행1 : TriggerState {
            internal State2_05게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격06 : TriggerState {
            internal State2스프링공격06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 120, 121, 128, 129, 131, 132, 133, 142, 143, 144, 145, 146, 155, 156, 157, 158, 159, 160, 161}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 220, 221, 228, 229, 231, 232, 233, 242, 243, 244, 245, 246, 255, 256, 257, 258, 259, 260, 261}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_06게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_06게임진행1 : TriggerState {
            internal State2_06게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격07 : TriggerState {
            internal State2스프링공격07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 111, 112, 115, 116, 117, 118, 119, 120, 121, 122, 127, 128, 129, 130, 131, 132, 133, 134, 137, 138, 143, 148, 149, 150, 151, 156, 157, 158, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 211, 212, 215, 216, 217, 218, 219, 220, 221, 222, 227, 228, 229, 230, 231, 232, 233, 234, 237, 238, 243, 248, 249, 250, 251, 256, 257, 258, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_07게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_07게임진행1 : TriggerState {
            internal State2_07게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격08 : TriggerState {
            internal State2스프링공격08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 131, 132, 133, 134, 135, 136, 138, 139, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 155, 156}, enabled: true);
                context.SetSkill(triggerIds: new []{207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 231, 232, 233, 234, 235, 236, 238, 239, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 255, 256}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_08게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_08게임진행1 : TriggerState {
            internal State2_08게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격09 : TriggerState {
            internal State2스프링공격09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 112, 113, 115, 116, 117, 118, 119, 122, 124, 125, 127, 130, 131, 132, 133, 134, 136, 137, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 212, 213, 215, 216, 217, 218, 219, 222, 224, 225, 227, 230, 231, 232, 233, 234, 236, 237, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_09게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_09게임진행1 : TriggerState {
            internal State2_09게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격10 : TriggerState {
            internal State2스프링공격10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 106, 107, 110, 111, 112, 113, 114, 115, 118, 131, 134, 135, 136, 137, 138, 139, 142, 143, 144, 147, 148, 149, 150, 151, 152, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 206, 207, 210, 211, 212, 213, 214, 215, 218, 231, 234, 235, 236, 237, 238, 239, 242, 243, 244, 247, 248, 249, 250, 251, 252, 255, 256, 257, 258, 259, 262, 263, 264, 236}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_10게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_10게임진행1 : TriggerState {
            internal State2_10게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격11 : TriggerState {
            internal State2스프링공격11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 112, 113, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 136, 137, 140, 141, 145, 146, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 212, 213, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 236, 237, 240, 241, 245, 246, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_11게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_11게임진행1 : TriggerState {
            internal State2_11게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격12 : TriggerState {
            internal State2스프링공격12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 107, 108, 113, 114, 115, 116, 119, 120, 125, 126, 127, 128, 131, 132, 138, 140, 142, 146, 147, 148, 149, 151, 153, 155, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 207, 208, 213, 214, 215, 216, 219, 220, 225, 226, 227, 228, 231, 232, 238, 240, 242, 246, 247, 248, 249, 251, 253, 255, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_12게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_12게임진행1 : TriggerState {
            internal State2_12게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격13 : TriggerState {
            internal State2스프링공격13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 105, 107, 109, 111, 113, 115, 117, 119, 121, 123, 125, 127, 129, 131, 133, 135, 137, 139, 141, 143, 145, 147, 149, 151, 153, 155, 157, 159, 161, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 205, 207, 209, 211, 213, 215, 217, 219, 221, 223, 225, 227, 229, 231, 233, 235, 237, 239, 241, 243, 245, 247, 249, 251, 253, 255, 257, 259, 261, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_13게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_13게임진행1 : TriggerState {
            internal State2_13게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격14 : TriggerState {
            internal State2스프링공격14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 106, 108, 109, 111, 114, 116, 117, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 132, 133, 135, 138, 139, 142, 143, 145, 146, 148, 150, 153, 154, 157, 159, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 206, 208, 209, 211, 214, 216, 217, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 232, 233, 235, 238, 239, 242, 243, 245, 246, 248, 250, 253, 254, 257, 259, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_14게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_14게임진행1 : TriggerState {
            internal State2_14게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격15 : TriggerState {
            internal State2스프링공격15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 105, 106, 109, 110, 111, 112, 115, 116, 117, 118, 119, 120, 123, 124, 125, 126, 127, 128, 131, 132, 133, 134, 137, 138, 140, 141, 143, 144, 145, 148, 149, 151, 153, 154, 156, 157, 158, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 205, 206, 209, 210, 211, 212, 215, 216, 217, 218, 219, 220, 223, 224, 225, 226, 227, 228, 231, 232, 233, 234, 237, 238, 240, 241, 243, 244, 245, 248, 249, 251, 253, 254, 256, 257, 258, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_15게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_15게임진행1 : TriggerState {
            internal State2_15게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격16 : TriggerState {
            internal State2스프링공격16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 140, 141, 145, 146, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 240, 241, 245, 246, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_16게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_16게임진행1 : TriggerState {
            internal State2_16게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격17 : TriggerState {
            internal State2스프링공격17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 116, 119, 120, 121, 122, 125, 126, 127, 128, 129, 130, 131, 132, 135, 136, 138, 139, 140, 142, 143, 146, 147, 148, 149, 151, 152, 153, 155, 156, 157, 158, 159, 160, 161, 162}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 211, 212, 213, 214, 215, 216, 219, 220, 221, 222, 225, 226, 227, 228, 229, 230, 231, 232, 235, 236, 238, 239, 240, 242, 243, 246, 247, 248, 249, 251, 252, 253, 255, 256, 257, 258, 259, 260, 261, 262}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_17게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_17게임진행1 : TriggerState {
            internal State2_17게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격18 : TriggerState {
            internal State2스프링공격18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 104, 105, 106, 107, 109, 110, 111, 113, 114, 116, 117, 118, 119, 121, 122, 123, 125, 126, 128, 129, 130, 131, 133, 134, 135, 138, 140, 142, 144, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 204, 205, 206, 207, 209, 210, 211, 213, 214, 216, 217, 218, 219, 221, 222, 223, 225, 226, 228, 229, 230, 231, 233, 234, 235, 238, 240, 242, 244, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_18게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_18게임진행1 : TriggerState {
            internal State2_18게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격19 : TriggerState {
            internal State2스프링공격19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 138, 139, 142, 143, 144, 145, 146, 147, 148, 150, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 238, 239, 242, 243, 244, 245, 246, 247, 248, 250, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_19게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_19게임진행1 : TriggerState {
            internal State2_19게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격20 : TriggerState {
            internal State2스프링공격20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 105, 106, 107, 108, 109, 110, 111, 112, 115, 116, 117, 118, 119, 121, 122, 123, 124, 125, 126, 127, 129, 130, 131, 132, 133, 134, 137, 138, 140, 141, 143, 144, 145, 146, 147, 148, 149, 150, 151, 153, 154, 156, 157, 158, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 205, 206, 207, 208, 209, 210, 211, 212, 215, 216, 217, 218, 219, 221, 222, 223, 224, 225, 226, 227, 229, 230, 231, 232, 233, 234, 237, 238, 240, 241, 243, 244, 245, 246, 247, 248, 249, 250, 251, 253, 254, 256, 257, 258, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_20게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_20게임진행1 : TriggerState {
            internal State2_20게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격21 : TriggerState {
            internal State2스프링공격21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 111, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 140, 141, 143, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 211, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 240, 241, 243, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_21게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_21게임진행1 : TriggerState {
            internal State2_21게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격22 : TriggerState {
            internal State2스프링공격22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113, 114, 115, 116, 118, 119, 120, 121, 122, 123, 125, 126, 127, 128, 129, 130, 131, 132, 134, 135, 136, 138, 139, 140, 141, 142, 143, 145, 146, 147, 148, 149, 150, 151, 152, 153, 155, 156, 157, 158, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 211, 212, 213, 214, 215, 216, 218, 219, 220, 221, 222, 223, 225, 226, 227, 228, 229, 230, 231, 232, 234, 235, 236, 238, 239, 240, 241, 242, 243, 245, 246, 247, 248, 249, 250, 251, 252, 253, 255, 256, 257, 258, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_22게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_22게임진행1 : TriggerState {
            internal State2_22게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격23 : TriggerState {
            internal State2스프링공격23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_23게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_23게임진행1 : TriggerState {
            internal State2_23게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격24 : TriggerState {
            internal State2스프링공격24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 138, 139, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 238, 239, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_24게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_24게임진행1 : TriggerState {
            internal State2_24게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격25 : TriggerState {
            internal State2스프링공격25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 113, 114, 115, 116, 117, 118, 119, 120, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 144, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 215, 216, 217, 218, 219, 220, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 239, 240, 241, 242, 244, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_25게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_25게임진행1 : TriggerState {
            internal State2_25게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격26 : TriggerState {
            internal State2스프링공격26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 115, 116, 119, 120, 122, 124, 125, 127, 129, 130, 132, 133, 135, 136, 137, 138, 139, 142, 143, 144, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 215, 216, 219, 220, 222, 224, 225, 227, 229, 230, 232, 233, 235, 236, 237, 238, 239, 242, 243, 244, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_26게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_26게임진행1 : TriggerState {
            internal State2_26게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격27 : TriggerState {
            internal State2스프링공격27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113, 114, 116, 117, 120, 121, 122, 123, 124, 125, 126, 127, 130, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 210, 211, 212, 213, 214, 216, 217, 220, 221, 222, 223, 224, 225, 226, 227, 230, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_27게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_27게임진행1 : TriggerState {
            internal State2_27게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격28 : TriggerState {
            internal State2스프링공격28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 110, 111, 112, 113, 116, 118, 119, 120, 122, 123, 126, 127, 129, 130, 131, 133, 136, 137, 139, 140, 142, 145, 146, 147, 148, 149, 150, 151, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 210, 211, 212, 213, 216, 218, 219, 220, 222, 223, 226, 227, 229, 230, 231, 233, 236, 237, 239, 240, 242, 245, 246, 247, 248, 249, 250, 251, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_28게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_28게임진행1 : TriggerState {
            internal State2_28게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격29 : TriggerState {
            internal State2스프링공격29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 109, 110, 112, 113, 115, 117, 118, 119, 120, 122, 124, 125, 127, 129, 130, 131, 132, 134, 136, 137, 138, 143, 146, 147, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 209, 210, 212, 213, 215, 217, 218, 219, 220, 222, 224, 225, 227, 229, 230, 231, 232, 234, 236, 237, 238, 243, 246, 247, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_29게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_29게임진행1 : TriggerState {
            internal State2_29게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격30 : TriggerState {
            internal State2스프링공격30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 112, 113, 114, 115, 116, 117, 119, 121, 122, 123, 124, 125, 126, 127, 129, 130, 131, 132, 133, 135, 136, 137, 139, 140, 141, 142, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 212, 213, 214, 215, 216, 217, 219, 221, 222, 223, 224, 225, 226, 227, 229, 230, 231, 232, 233, 235, 236, 237, 239, 240, 241, 242, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_30게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_30게임진행1 : TriggerState {
            internal State2_30게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격31 : TriggerState {
            internal State2스프링공격31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 113, 115, 116, 117, 118, 119, 120, 121, 123, 124, 125, 126, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 213, 215, 216, 217, 218, 219, 220, 221, 223, 224, 225, 226, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_31게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_31게임진행1 : TriggerState {
            internal State2_31게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격32 : TriggerState {
            internal State2스프링공격32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 131, 132, 133, 134, 135, 136, 137, 138, 140, 141, 143, 144, 145, 146, 147, 148, 149, 150, 152, 153, 154, 155, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 231, 232, 233, 234, 235, 236, 237, 238, 240, 241, 243, 244, 245, 246, 247, 248, 249, 250, 252, 253, 254, 255, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_32게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_32게임진행1 : TriggerState {
            internal State2_32게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격33 : TriggerState {
            internal State2스프링공격33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 105, 106, 107, 108, 109, 111, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 156, 157, 158, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 205, 206, 207, 208, 209, 211, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 256, 257, 258, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_33게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_33게임진행1 : TriggerState {
            internal State2_33게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격34 : TriggerState {
            internal State2스프링공격34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 125, 126, 127, 128, 130, 131, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 210, 211, 212, 213, 214, 216, 218, 219, 221, 222, 223, 224, 225, 226, 227, 228, 230, 231, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_34게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_34게임진행1 : TriggerState {
            internal State2_34게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격35 : TriggerState {
            internal State2스프링공격35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 116, 117, 118, 122, 123, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 139, 140, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 216, 217, 218, 222, 223, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 239, 240, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_35게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_35게임진행1 : TriggerState {
            internal State2_35게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격36 : TriggerState {
            internal State2스프링공격36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 153, 154, 155, 156, 158, 159, 160, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 253, 254, 255, 256, 258, 259, 260, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_36게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_36게임진행1 : TriggerState {
            internal State2_36게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격37 : TriggerState {
            internal State2스프링공격37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_37게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_37게임진행1 : TriggerState {
            internal State2_37게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격38 : TriggerState {
            internal State2스프링공격38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_38게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_38게임진행1 : TriggerState {
            internal State2_38게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격39 : TriggerState {
            internal State2스프링공격39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 130, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 144, 145, 146, 147, 149, 150, 151, 152, 153, 154, 155, 156, 158, 159, 160, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 230, 232, 233, 235, 236, 237, 238, 239, 240, 241, 242, 244, 245, 246, 247, 249, 250, 251, 252, 253, 254, 255, 256, 258, 259, 260, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_39게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_39게임진행1 : TriggerState {
            internal State2_39게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2스프링공격40 : TriggerState {
            internal State2스프링공격40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 113, 114, 116, 117, 119, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 216, 217, 219, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State2_40게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2_40게임진행1 : TriggerState {
            internal State2_40게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격01 : TriggerState {
            internal State3스프링공격01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{105, 106, 107, 108, 117, 118, 119, 120, 129, 130, 131, 132, 137, 138, 139, 140, 141, 142, 143, 144, 145, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{205, 206, 207, 208, 217, 218, 219, 220, 229, 230, 231, 232, 237, 238, 239, 240, 241, 242, 243, 244, 245, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_01게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_01게임진행1 : TriggerState {
            internal State3_01게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격02 : TriggerState {
            internal State3스프링공격02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 137, 138, 139, 140, 150, 151, 152, 153}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 237, 238, 239, 240, 250, 251, 252, 253}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_02게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_02게임진행1 : TriggerState {
            internal State3_02게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격03 : TriggerState {
            internal State3스프링공격03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 109, 110, 111, 112, 113, 114, 115, 116, 121, 122, 123, 124, 129, 130, 131, 132, 141, 142, 143, 144, 145, 154, 155, 156, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 209, 210, 211, 212, 213, 214, 215, 216, 221, 222, 223, 224, 229, 230, 231, 232, 241, 242, 243, 244, 245, 254, 255, 256, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_03게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_03게임진행1 : TriggerState {
            internal State3_03게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격04 : TriggerState {
            internal State3스프링공격04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{107, 117, 118, 119, 120, 121, 127, 128, 129, 133, 134, 135, 137, 138, 139, 147, 148, 149, 150, 151, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{207, 217, 218, 219, 220, 221, 227, 228, 229, 233, 234, 235, 237, 238, 239, 247, 248, 249, 250, 251, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_04게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_04게임진행1 : TriggerState {
            internal State3_04게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격05 : TriggerState {
            internal State3스프링공격05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{104, 105, 108, 109, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 140, 141, 145, 146, 153, 154, 160, 161}, enabled: true);
                context.SetSkill(triggerIds: new []{204, 205, 208, 209, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 240, 241, 245, 246, 253, 254, 260, 261}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_05게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_05게임진행1 : TriggerState {
            internal State3_05게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격06 : TriggerState {
            internal State3스프링공격06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 120, 121, 128, 129, 131, 132, 133, 142, 143, 144, 145, 146, 155, 156, 157, 158, 159, 160, 161}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 220, 221, 228, 229, 231, 232, 233, 242, 243, 244, 245, 246, 255, 256, 257, 258, 259, 260, 261}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_06게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_06게임진행1 : TriggerState {
            internal State3_06게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격07 : TriggerState {
            internal State3스프링공격07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 111, 112, 115, 116, 117, 118, 119, 120, 121, 122, 127, 128, 129, 130, 131, 132, 133, 134, 137, 138, 143, 148, 149, 150, 151, 156, 157, 158, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 211, 212, 215, 216, 217, 218, 219, 220, 221, 222, 227, 228, 229, 230, 231, 232, 233, 234, 237, 238, 243, 248, 249, 250, 251, 256, 257, 258, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_07게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_07게임진행1 : TriggerState {
            internal State3_07게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격08 : TriggerState {
            internal State3스프링공격08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 131, 132, 133, 134, 135, 136, 138, 139, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 155, 156}, enabled: true);
                context.SetSkill(triggerIds: new []{207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 231, 232, 233, 234, 235, 236, 238, 239, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 255, 256}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_08게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_08게임진행1 : TriggerState {
            internal State3_08게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격09 : TriggerState {
            internal State3스프링공격09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 112, 113, 115, 116, 117, 118, 119, 122, 124, 125, 127, 130, 131, 132, 133, 134, 136, 137, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 212, 213, 215, 216, 217, 218, 219, 222, 224, 225, 227, 230, 231, 232, 233, 234, 236, 237, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_09게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_09게임진행1 : TriggerState {
            internal State3_09게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격10 : TriggerState {
            internal State3스프링공격10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 106, 107, 110, 111, 112, 113, 114, 115, 118, 131, 134, 135, 136, 137, 138, 139, 142, 143, 144, 147, 148, 149, 150, 151, 152, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 206, 207, 210, 211, 212, 213, 214, 215, 218, 231, 234, 235, 236, 237, 238, 239, 242, 243, 244, 247, 248, 249, 250, 251, 252, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_10게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_10게임진행1 : TriggerState {
            internal State3_10게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격11 : TriggerState {
            internal State3스프링공격11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 112, 113, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 136, 137, 140, 141, 145, 146, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 212, 213, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 236, 237, 240, 241, 245, 246, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_11게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_11게임진행1 : TriggerState {
            internal State3_11게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격12 : TriggerState {
            internal State3스프링공격12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 107, 108, 113, 114, 115, 116, 119, 120, 125, 126, 127, 128, 131, 132, 138, 140, 142, 146, 147, 148, 149, 151, 153, 155, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 207, 208, 213, 214, 215, 216, 219, 220, 225, 226, 227, 228, 231, 232, 238, 240, 242, 246, 247, 248, 249, 251, 253, 255, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_12게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_12게임진행1 : TriggerState {
            internal State3_12게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격13 : TriggerState {
            internal State3스프링공격13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 105, 107, 109, 111, 113, 115, 117, 119, 121, 123, 125, 127, 129, 131, 133, 135, 137, 139, 141, 143, 145, 147, 149, 151, 153, 155, 157, 159, 161, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 205, 207, 209, 211, 213, 215, 217, 219, 221, 223, 225, 227, 229, 231, 233, 235, 237, 239, 241, 243, 245, 247, 249, 251, 253, 255, 257, 259, 261, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_13게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_13게임진행1 : TriggerState {
            internal State3_13게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격14 : TriggerState {
            internal State3스프링공격14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 106, 108, 109, 111, 114, 116, 117, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 132, 133, 135, 138, 139, 142, 143, 145, 146, 148, 150, 153, 154, 157, 159, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 206, 208, 209, 211, 214, 216, 217, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 232, 233, 235, 238, 239, 242, 243, 245, 246, 248, 250, 253, 254, 257, 259, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_14게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_14게임진행1 : TriggerState {
            internal State3_14게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격15 : TriggerState {
            internal State3스프링공격15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 105, 106, 109, 110, 111, 112, 115, 116, 117, 118, 119, 120, 123, 124, 125, 126, 127, 128, 131, 132, 133, 134, 137, 138, 140, 141, 143, 144, 145, 148, 149, 151, 153, 154, 156, 157, 158, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 205, 206, 209, 210, 211, 212, 215, 216, 217, 218, 219, 220, 223, 224, 225, 226, 227, 228, 231, 232, 233, 234, 237, 238, 240, 241, 243, 244, 245, 248, 249, 251, 253, 254, 256, 257, 258, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_15게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_15게임진행1 : TriggerState {
            internal State3_15게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격16 : TriggerState {
            internal State3스프링공격16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 140, 141, 145, 146, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 240, 241, 245, 246, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_16게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_16게임진행1 : TriggerState {
            internal State3_16게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격17 : TriggerState {
            internal State3스프링공격17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 116, 119, 120, 121, 122, 125, 126, 127, 128, 129, 130, 131, 132, 135, 136, 138, 139, 140, 142, 143, 146, 147, 148, 149, 151, 152, 153, 155, 156, 157, 158, 159, 160, 161, 162}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 211, 212, 213, 214, 215, 216, 219, 220, 221, 222, 225, 226, 227, 228, 229, 230, 231, 232, 235, 236, 238, 239, 240, 242, 243, 246, 247, 248, 249, 251, 252, 253, 255, 256, 257, 258, 259, 260, 261, 262}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_17게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_17게임진행1 : TriggerState {
            internal State3_17게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격18 : TriggerState {
            internal State3스프링공격18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 104, 105, 106, 107, 109, 110, 111, 113, 114, 116, 117, 118, 119, 121, 122, 123, 125, 126, 128, 129, 130, 131, 133, 134, 135, 138, 140, 142, 144, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 204, 205, 206, 207, 209, 210, 211, 213, 214, 216, 217, 218, 219, 221, 222, 223, 225, 226, 228, 229, 230, 231, 233, 234, 235, 238, 240, 242, 244, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_18게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_18게임진행1 : TriggerState {
            internal State3_18게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격19 : TriggerState {
            internal State3스프링공격19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 138, 139, 142, 143, 144, 145, 146, 147, 148, 150, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 238, 239, 242, 243, 244, 245, 246, 247, 248, 250, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_19게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_19게임진행1 : TriggerState {
            internal State3_19게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격20 : TriggerState {
            internal State3스프링공격20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 105, 106, 107, 108, 109, 110, 111, 112, 115, 116, 117, 118, 119, 121, 122, 123, 124, 125, 126, 127, 129, 130, 131, 132, 133, 134, 137, 138, 140, 141, 143, 144, 145, 146, 147, 148, 149, 150, 151, 153, 154, 156, 157, 158, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 205, 206, 207, 208, 209, 210, 211, 212, 215, 216, 217, 218, 219, 221, 222, 223, 224, 225, 226, 227, 229, 230, 231, 232, 233, 234, 237, 238, 240, 241, 243, 244, 245, 246, 247, 248, 249, 250, 251, 253, 254, 256, 257, 258, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_20게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_20게임진행1 : TriggerState {
            internal State3_20게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격21 : TriggerState {
            internal State3스프링공격21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 111, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 140, 141, 143, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 211, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 240, 241, 243, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_21게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_21게임진행1 : TriggerState {
            internal State3_21게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격22 : TriggerState {
            internal State3스프링공격22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113, 114, 115, 116, 118, 119, 120, 121, 122, 123, 125, 126, 127, 128, 129, 130, 131, 132, 134, 135, 136, 138, 139, 140, 141, 142, 143, 145, 146, 147, 148, 149, 150, 151, 152, 153, 155, 156, 157, 158, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 211, 212, 213, 214, 215, 216, 218, 219, 220, 221, 222, 223, 225, 226, 227, 228, 229, 230, 231, 232, 234, 235, 236, 238, 239, 240, 241, 242, 243, 245, 246, 247, 248, 249, 250, 251, 252, 253, 255, 256, 257, 258, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_22게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_22게임진행1 : TriggerState {
            internal State3_22게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격23 : TriggerState {
            internal State3스프링공격23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_23게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_23게임진행1 : TriggerState {
            internal State3_23게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격24 : TriggerState {
            internal State3스프링공격24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 138, 139, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 238, 239, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_24게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_24게임진행1 : TriggerState {
            internal State3_24게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격25 : TriggerState {
            internal State3스프링공격25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 113, 114, 115, 116, 117, 118, 119, 120, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 144, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 215, 216, 217, 218, 219, 220, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 239, 240, 241, 242, 244, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_25게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_25게임진행1 : TriggerState {
            internal State3_25게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격26 : TriggerState {
            internal State3스프링공격26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 115, 116, 119, 120, 122, 124, 125, 127, 129, 130, 132, 133, 135, 136, 137, 138, 139, 142, 143, 144, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 215, 216, 219, 220, 222, 224, 225, 227, 229, 230, 232, 233, 235, 236, 237, 238, 239, 242, 243, 244, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_26게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_26게임진행1 : TriggerState {
            internal State3_26게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격27 : TriggerState {
            internal State3스프링공격27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113, 114, 116, 117, 120, 121, 122, 123, 124, 125, 126, 127, 130, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 210, 211, 212, 213, 214, 216, 217, 220, 221, 222, 223, 224, 225, 226, 227, 230, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_27게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_27게임진행1 : TriggerState {
            internal State3_27게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격28 : TriggerState {
            internal State3스프링공격28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 110, 111, 112, 113, 116, 118, 119, 120, 122, 123, 126, 127, 129, 130, 131, 133, 136, 137, 139, 140, 142, 145, 146, 147, 148, 149, 150, 151, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 210, 211, 212, 213, 216, 218, 219, 220, 222, 223, 226, 227, 229, 230, 231, 233, 236, 237, 239, 240, 242, 245, 246, 247, 248, 249, 250, 251, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_28게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_28게임진행1 : TriggerState {
            internal State3_28게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격29 : TriggerState {
            internal State3스프링공격29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 109, 110, 112, 113, 115, 117, 118, 119, 120, 122, 124, 125, 127, 129, 130, 131, 132, 134, 136, 137, 138, 143, 146, 147, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 209, 210, 212, 213, 215, 217, 218, 219, 220, 222, 224, 225, 227, 229, 230, 231, 232, 234, 236, 237, 238, 243, 246, 247, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_29게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_29게임진행1 : TriggerState {
            internal State3_29게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격30 : TriggerState {
            internal State3스프링공격30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 112, 113, 114, 115, 116, 117, 119, 121, 122, 123, 124, 125, 126, 127, 129, 130, 131, 132, 133, 135, 136, 137, 139, 140, 141, 142, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 212, 213, 214, 215, 216, 217, 219, 221, 222, 223, 224, 225, 226, 227, 229, 230, 231, 232, 233, 235, 236, 237, 239, 240, 241, 242, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_30게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_30게임진행1 : TriggerState {
            internal State3_30게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격31 : TriggerState {
            internal State3스프링공격31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 113, 115, 116, 117, 118, 119, 120, 121, 123, 124, 125, 126, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 213, 215, 216, 217, 218, 219, 220, 221, 223, 224, 225, 226, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_31게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_31게임진행1 : TriggerState {
            internal State3_31게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격32 : TriggerState {
            internal State3스프링공격32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 131, 132, 133, 134, 135, 136, 137, 138, 140, 141, 143, 144, 145, 146, 147, 148, 149, 150, 152, 153, 154, 155, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 231, 232, 233, 234, 235, 236, 237, 238, 240, 241, 243, 244, 245, 246, 247, 248, 249, 250, 252, 253, 254, 255, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_32게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_32게임진행1 : TriggerState {
            internal State3_32게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격33 : TriggerState {
            internal State3스프링공격33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 105, 106, 107, 108, 109, 111, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 156, 157, 158, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 205, 206, 207, 208, 209, 211, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 256, 257, 258, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_33게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_33게임진행1 : TriggerState {
            internal State3_33게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격34 : TriggerState {
            internal State3스프링공격34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 125, 126, 127, 128, 130, 131, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 210, 211, 212, 213, 214, 216, 218, 219, 221, 222, 223, 224, 225, 226, 227, 228, 230, 231, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_34게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_34게임진행1 : TriggerState {
            internal State3_34게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격35 : TriggerState {
            internal State3스프링공격35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 116, 117, 118, 122, 123, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 139, 140, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 216, 217, 218, 222, 223, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 239, 240, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_35게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_35게임진행1 : TriggerState {
            internal State3_35게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격36 : TriggerState {
            internal State3스프링공격36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 153, 154, 155, 156, 158, 159, 160, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 253, 254, 255, 256, 258, 259, 260, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_36게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_36게임진행1 : TriggerState {
            internal State3_36게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격37 : TriggerState {
            internal State3스프링공격37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_37게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_37게임진행1 : TriggerState {
            internal State3_37게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격38 : TriggerState {
            internal State3스프링공격38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_38게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_38게임진행1 : TriggerState {
            internal State3_38게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격39 : TriggerState {
            internal State3스프링공격39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 130, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 144, 145, 146, 147, 149, 150, 151, 152, 153, 154, 155, 156, 158, 159, 160, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 230, 232, 233, 235, 236, 237, 238, 239, 240, 241, 242, 244, 245, 246, 247, 249, 250, 251, 252, 253, 254, 255, 256, 258, 259, 260, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_39게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_39게임진행1 : TriggerState {
            internal State3_39게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3스프링공격40 : TriggerState {
            internal State3스프링공격40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 113, 114, 116, 117, 119, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 216, 217, 219, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State3_40게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3_40게임진행1 : TriggerState {
            internal State3_40게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격01 : TriggerState {
            internal State4스프링공격01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{105, 106, 107, 108, 117, 118, 119, 120, 129, 130, 131, 132, 137, 138, 139, 140, 141, 142, 143, 144, 145, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{205, 206, 207, 208, 217, 218, 219, 220, 229, 230, 231, 232, 237, 238, 239, 240, 241, 242, 243, 244, 245, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_01게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_01게임진행1 : TriggerState {
            internal State4_01게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격02 : TriggerState {
            internal State4스프링공격02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 137, 138, 139, 140, 150, 151, 152, 153}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 237, 238, 239, 240, 250, 251, 252, 253}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_02게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_02게임진행1 : TriggerState {
            internal State4_02게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격03 : TriggerState {
            internal State4스프링공격03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 109, 110, 111, 112, 113, 114, 115, 116, 121, 122, 123, 124, 129, 130, 131, 132, 141, 142, 143, 144, 145, 154, 155, 156, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 209, 210, 211, 212, 213, 214, 215, 216, 221, 222, 223, 224, 229, 230, 231, 232, 241, 242, 243, 244, 245, 254, 255, 256, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_03게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_03게임진행1 : TriggerState {
            internal State4_03게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격04 : TriggerState {
            internal State4스프링공격04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{107, 117, 118, 119, 120, 121, 127, 128, 129, 133, 134, 135, 137, 138, 139, 147, 148, 149, 150, 151, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{207, 217, 218, 219, 220, 221, 227, 228, 229, 233, 234, 235, 237, 238, 239, 247, 248, 249, 250, 251, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_04게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_04게임진행1 : TriggerState {
            internal State4_04게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격05 : TriggerState {
            internal State4스프링공격05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{104, 105, 108, 109, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 140, 141, 145, 146, 153, 154, 160, 161}, enabled: true);
                context.SetSkill(triggerIds: new []{204, 205, 208, 209, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 240, 241, 245, 246, 253, 254, 260, 261}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_05게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_05게임진행1 : TriggerState {
            internal State4_05게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격06 : TriggerState {
            internal State4스프링공격06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 120, 121, 128, 129, 131, 132, 133, 142, 143, 144, 145, 146, 155, 156, 157, 158, 159, 160, 161}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 220, 221, 228, 229, 231, 232, 233, 242, 243, 244, 245, 246, 255, 256, 257, 258, 259, 260, 261}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_06게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_06게임진행1 : TriggerState {
            internal State4_06게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격07 : TriggerState {
            internal State4스프링공격07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 111, 112, 115, 116, 117, 118, 119, 120, 121, 122, 127, 128, 129, 130, 131, 132, 133, 134, 137, 138, 143, 148, 149, 150, 151, 156, 157, 158, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 211, 212, 215, 216, 217, 218, 219, 220, 221, 222, 227, 228, 229, 230, 231, 232, 233, 234, 237, 238, 243, 248, 249, 250, 251, 256, 257, 258, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_07게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_07게임진행1 : TriggerState {
            internal State4_07게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격08 : TriggerState {
            internal State4스프링공격08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 131, 132, 133, 134, 135, 136, 138, 139, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 155, 156}, enabled: true);
                context.SetSkill(triggerIds: new []{207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 231, 232, 233, 234, 235, 236, 238, 239, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 255, 256}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_08게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_08게임진행1 : TriggerState {
            internal State4_08게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격09 : TriggerState {
            internal State4스프링공격09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 112, 113, 115, 116, 117, 118, 119, 122, 124, 125, 127, 130, 131, 132, 133, 134, 136, 137, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 212, 213, 215, 216, 217, 218, 219, 222, 224, 225, 227, 230, 231, 232, 233, 234, 236, 237, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_09게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_09게임진행1 : TriggerState {
            internal State4_09게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격10 : TriggerState {
            internal State4스프링공격10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 106, 107, 110, 111, 112, 113, 114, 115, 118, 131, 134, 135, 136, 137, 138, 139, 142, 143, 144, 147, 148, 149, 150, 151, 152, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 206, 207, 210, 211, 212, 213, 214, 215, 218, 231, 234, 235, 236, 237, 238, 239, 242, 243, 244, 247, 248, 249, 250, 251, 252, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_10게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_10게임진행1 : TriggerState {
            internal State4_10게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격11 : TriggerState {
            internal State4스프링공격11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 112, 113, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 136, 137, 140, 141, 145, 146, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 212, 213, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 236, 237, 240, 241, 245, 246, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_11게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_11게임진행1 : TriggerState {
            internal State4_11게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격12 : TriggerState {
            internal State4스프링공격12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 107, 108, 113, 114, 115, 116, 119, 120, 125, 126, 127, 128, 131, 132, 138, 140, 142, 146, 147, 148, 149, 151, 153, 155, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 207, 208, 213, 214, 215, 216, 219, 220, 225, 226, 227, 228, 231, 232, 238, 240, 242, 246, 247, 248, 249, 251, 253, 255, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_12게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_12게임진행1 : TriggerState {
            internal State4_12게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격13 : TriggerState {
            internal State4스프링공격13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 105, 107, 109, 111, 113, 115, 117, 119, 121, 123, 125, 127, 129, 131, 133, 135, 137, 139, 141, 143, 145, 147, 149, 151, 153, 155, 157, 159, 161, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 205, 207, 209, 211, 213, 215, 217, 219, 221, 223, 225, 227, 229, 231, 233, 235, 237, 239, 241, 243, 245, 247, 249, 251, 253, 255, 257, 259, 261, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_13게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_13게임진행1 : TriggerState {
            internal State4_13게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격14 : TriggerState {
            internal State4스프링공격14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 106, 108, 109, 111, 114, 116, 117, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 132, 133, 135, 138, 139, 142, 143, 145, 146, 148, 150, 153, 154, 157, 159, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 206, 208, 209, 211, 214, 216, 217, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 232, 233, 235, 238, 239, 242, 243, 245, 246, 248, 250, 253, 254, 257, 259, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_14게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_14게임진행1 : TriggerState {
            internal State4_14게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격15 : TriggerState {
            internal State4스프링공격15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 105, 106, 109, 110, 111, 112, 115, 116, 117, 118, 119, 120, 123, 124, 125, 126, 127, 128, 131, 132, 133, 134, 137, 138, 140, 141, 143, 144, 145, 148, 149, 151, 153, 154, 156, 157, 158, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 205, 206, 209, 210, 211, 212, 215, 216, 217, 218, 219, 220, 223, 224, 225, 226, 227, 228, 231, 232, 233, 234, 237, 238, 240, 241, 243, 244, 245, 248, 249, 251, 253, 254, 256, 257, 258, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_15게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_15게임진행1 : TriggerState {
            internal State4_15게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격16 : TriggerState {
            internal State4스프링공격16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 140, 141, 145, 146, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 240, 241, 245, 246, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_16게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_16게임진행1 : TriggerState {
            internal State4_16게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격17 : TriggerState {
            internal State4스프링공격17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 116, 119, 120, 121, 122, 125, 126, 127, 128, 129, 130, 131, 132, 135, 136, 138, 139, 140, 142, 143, 146, 147, 148, 149, 151, 152, 153, 155, 156, 157, 158, 159, 160, 161, 162}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 211, 212, 213, 214, 215, 216, 219, 220, 221, 222, 225, 226, 227, 228, 229, 230, 231, 232, 235, 236, 238, 239, 240, 242, 243, 246, 247, 248, 249, 251, 252, 253, 255, 256, 257, 258, 259, 260, 261, 262}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_17게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_17게임진행1 : TriggerState {
            internal State4_17게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격18 : TriggerState {
            internal State4스프링공격18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 104, 105, 106, 107, 109, 110, 111, 113, 114, 116, 117, 118, 119, 121, 122, 123, 125, 126, 128, 129, 130, 131, 133, 134, 135, 138, 140, 142, 144, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 204, 205, 206, 207, 209, 210, 211, 213, 214, 216, 217, 218, 219, 221, 222, 223, 225, 226, 228, 229, 230, 231, 233, 234, 235, 238, 240, 242, 244, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_18게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_18게임진행1 : TriggerState {
            internal State4_18게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격19 : TriggerState {
            internal State4스프링공격19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 138, 139, 142, 143, 144, 145, 146, 147, 148, 150, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 238, 239, 242, 243, 244, 245, 246, 247, 248, 250, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_19게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_19게임진행1 : TriggerState {
            internal State4_19게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격20 : TriggerState {
            internal State4스프링공격20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 105, 106, 107, 108, 109, 110, 111, 112, 115, 116, 117, 118, 119, 121, 122, 123, 124, 125, 126, 127, 129, 130, 131, 132, 133, 134, 137, 138, 140, 141, 143, 144, 145, 146, 147, 148, 149, 150, 151, 153, 154, 156, 157, 158, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 205, 206, 207, 208, 209, 210, 211, 212, 215, 216, 217, 218, 219, 221, 222, 223, 224, 225, 226, 227, 229, 230, 231, 232, 233, 234, 237, 238, 240, 241, 243, 244, 245, 246, 247, 248, 249, 250, 251, 253, 254, 256, 257, 258, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_20게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_20게임진행1 : TriggerState {
            internal State4_20게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격21 : TriggerState {
            internal State4스프링공격21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 111, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 140, 141, 143, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 211, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 240, 241, 243, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_21게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_21게임진행1 : TriggerState {
            internal State4_21게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격22 : TriggerState {
            internal State4스프링공격22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113, 114, 115, 116, 118, 119, 120, 121, 122, 123, 125, 126, 127, 128, 129, 130, 131, 132, 134, 135, 136, 138, 139, 140, 141, 142, 143, 145, 146, 147, 148, 149, 150, 151, 152, 153, 155, 156, 157, 158, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 211, 212, 213, 214, 215, 216, 218, 219, 220, 221, 222, 223, 225, 226, 227, 228, 229, 230, 231, 232, 234, 235, 236, 238, 239, 240, 241, 242, 243, 245, 246, 247, 248, 249, 250, 251, 252, 253, 255, 256, 257, 258, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_22게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_22게임진행1 : TriggerState {
            internal State4_22게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격23 : TriggerState {
            internal State4스프링공격23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_23게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_23게임진행1 : TriggerState {
            internal State4_23게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격24 : TriggerState {
            internal State4스프링공격24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 138, 139, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 238, 239, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_24게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_24게임진행1 : TriggerState {
            internal State4_24게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격25 : TriggerState {
            internal State4스프링공격25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 113, 114, 115, 116, 117, 118, 119, 120, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 144, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 215, 216, 217, 218, 219, 220, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 239, 240, 241, 242, 244, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_25게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_25게임진행1 : TriggerState {
            internal State4_25게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격26 : TriggerState {
            internal State4스프링공격26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 115, 116, 119, 120, 122, 124, 125, 127, 129, 130, 132, 133, 135, 136, 137, 138, 139, 142, 143, 144, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 215, 216, 219, 220, 222, 224, 225, 227, 229, 230, 232, 233, 235, 236, 237, 238, 239, 242, 243, 244, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_26게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_26게임진행1 : TriggerState {
            internal State4_26게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격27 : TriggerState {
            internal State4스프링공격27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113, 114, 116, 117, 120, 121, 122, 123, 124, 125, 126, 127, 130, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 210, 211, 212, 213, 214, 216, 217, 220, 221, 222, 223, 224, 225, 226, 227, 230, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_27게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_27게임진행1 : TriggerState {
            internal State4_27게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격28 : TriggerState {
            internal State4스프링공격28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 110, 111, 112, 113, 116, 118, 119, 120, 122, 123, 126, 127, 129, 130, 131, 133, 136, 137, 139, 140, 142, 145, 146, 147, 148, 149, 150, 151, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 210, 211, 212, 213, 216, 218, 219, 220, 222, 223, 226, 227, 229, 230, 231, 233, 236, 237, 239, 240, 242, 245, 246, 247, 248, 249, 250, 251, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_28게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_28게임진행1 : TriggerState {
            internal State4_28게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격29 : TriggerState {
            internal State4스프링공격29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 109, 110, 112, 113, 115, 117, 118, 119, 120, 122, 124, 125, 127, 129, 130, 131, 132, 134, 136, 137, 138, 143, 146, 147, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 209, 210, 212, 213, 215, 217, 218, 219, 220, 222, 224, 225, 227, 229, 230, 231, 232, 234, 236, 237, 238, 243, 246, 247, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_29게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_29게임진행1 : TriggerState {
            internal State4_29게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격30 : TriggerState {
            internal State4스프링공격30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 112, 113, 114, 115, 116, 117, 119, 121, 122, 123, 124, 125, 126, 127, 129, 130, 131, 132, 133, 135, 136, 137, 139, 140, 141, 142, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 212, 213, 214, 215, 216, 217, 219, 221, 222, 223, 224, 225, 226, 227, 229, 230, 231, 232, 233, 235, 236, 237, 239, 240, 241, 242, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_30게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_30게임진행1 : TriggerState {
            internal State4_30게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격31 : TriggerState {
            internal State4스프링공격31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 113, 115, 116, 117, 118, 119, 120, 121, 123, 124, 125, 126, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 213, 215, 216, 217, 218, 219, 220, 221, 223, 224, 225, 226, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_31게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_31게임진행1 : TriggerState {
            internal State4_31게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격32 : TriggerState {
            internal State4스프링공격32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 131, 132, 133, 134, 135, 136, 137, 138, 140, 141, 143, 144, 145, 146, 147, 148, 149, 150, 152, 153, 154, 155, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 231, 232, 233, 234, 235, 236, 237, 238, 240, 241, 243, 244, 245, 246, 247, 248, 249, 250, 252, 253, 254, 255, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_32게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_32게임진행1 : TriggerState {
            internal State4_32게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격33 : TriggerState {
            internal State4스프링공격33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 105, 106, 107, 108, 109, 111, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 156, 157, 158, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 205, 206, 207, 208, 209, 211, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 256, 257, 258, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_33게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_33게임진행1 : TriggerState {
            internal State4_33게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격34 : TriggerState {
            internal State4스프링공격34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 125, 126, 127, 128, 130, 131, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 210, 211, 212, 213, 214, 216, 218, 219, 221, 222, 223, 224, 225, 226, 227, 228, 230, 231, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_34게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_34게임진행1 : TriggerState {
            internal State4_34게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격35 : TriggerState {
            internal State4스프링공격35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 116, 117, 118, 122, 123, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 139, 140, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 216, 217, 218, 222, 223, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 239, 240, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_35게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_35게임진행1 : TriggerState {
            internal State4_35게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격36 : TriggerState {
            internal State4스프링공격36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 153, 154, 155, 156, 158, 159, 160, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 253, 254, 255, 256, 258, 259, 260, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_36게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_36게임진행1 : TriggerState {
            internal State4_36게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격37 : TriggerState {
            internal State4스프링공격37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_37게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_37게임진행1 : TriggerState {
            internal State4_37게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격38 : TriggerState {
            internal State4스프링공격38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_38게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_38게임진행1 : TriggerState {
            internal State4_38게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격39 : TriggerState {
            internal State4스프링공격39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 130, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 144, 145, 146, 147, 149, 150, 151, 152, 153, 154, 155, 156, 158, 159, 160, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 230, 232, 233, 235, 236, 237, 238, 239, 240, 241, 242, 244, 245, 246, 247, 249, 250, 251, 252, 253, 254, 255, 256, 258, 259, 260, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_39게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_39게임진행1 : TriggerState {
            internal State4_39게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4스프링공격40 : TriggerState {
            internal State4스프링공격40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 113, 114, 116, 117, 119, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 216, 217, 219, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State4_40게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4_40게임진행1 : TriggerState {
            internal State4_40게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격01 : TriggerState {
            internal State5스프링공격01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{105, 106, 107, 108, 117, 118, 119, 120, 129, 130, 131, 132, 137, 138, 139, 140, 141, 142, 143, 144, 145, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{205, 206, 207, 208, 217, 218, 219, 220, 229, 230, 231, 232, 237, 238, 239, 240, 241, 242, 243, 244, 245, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_01게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_01게임진행1 : TriggerState {
            internal State5_01게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격02 : TriggerState {
            internal State5스프링공격02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 137, 138, 139, 140, 150, 151, 152, 153}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 237, 238, 239, 240, 250, 251, 252, 253}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_02게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_02게임진행1 : TriggerState {
            internal State5_02게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격03 : TriggerState {
            internal State5스프링공격03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 109, 110, 111, 112, 113, 114, 115, 116, 121, 122, 123, 124, 129, 130, 131, 132, 141, 142, 143, 144, 145, 154, 155, 156, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 209, 210, 211, 212, 213, 214, 215, 216, 221, 222, 223, 224, 229, 230, 231, 232, 241, 242, 243, 244, 245, 254, 255, 256, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_03게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_03게임진행1 : TriggerState {
            internal State5_03게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격04 : TriggerState {
            internal State5스프링공격04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{107, 117, 118, 119, 120, 121, 127, 128, 129, 133, 134, 135, 137, 138, 139, 147, 148, 149, 150, 151, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{207, 217, 218, 219, 220, 221, 227, 228, 229, 233, 234, 235, 237, 238, 239, 247, 248, 249, 250, 251, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_04게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_04게임진행1 : TriggerState {
            internal State5_04게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격05 : TriggerState {
            internal State5스프링공격05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{104, 105, 108, 109, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 140, 141, 145, 146, 153, 154, 160, 161}, enabled: true);
                context.SetSkill(triggerIds: new []{204, 205, 208, 209, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 240, 241, 245, 246, 253, 254, 260, 261}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_05게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_05게임진행1 : TriggerState {
            internal State5_05게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격06 : TriggerState {
            internal State5스프링공격06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 120, 121, 128, 129, 131, 132, 133, 142, 143, 144, 145, 146, 155, 156, 157, 158, 159, 160, 161}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 220, 221, 228, 229, 231, 232, 233, 242, 243, 244, 245, 246, 255, 256, 257, 258, 259, 260, 261}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_06게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_06게임진행1 : TriggerState {
            internal State5_06게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격07 : TriggerState {
            internal State5스프링공격07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 111, 112, 115, 116, 117, 118, 119, 120, 121, 122, 127, 128, 129, 130, 131, 132, 133, 134, 137, 138, 143, 148, 149, 150, 151, 156, 157, 158, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 211, 212, 215, 216, 217, 218, 219, 220, 221, 222, 227, 228, 229, 230, 231, 232, 233, 234, 237, 238, 243, 248, 249, 250, 251, 256, 257, 258, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_07게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_07게임진행1 : TriggerState {
            internal State5_07게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격08 : TriggerState {
            internal State5스프링공격08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 131, 132, 133, 134, 135, 136, 138, 139, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 155, 156}, enabled: true);
                context.SetSkill(triggerIds: new []{207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 231, 232, 233, 234, 235, 236, 238, 239, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 255, 256}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_08게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_08게임진행1 : TriggerState {
            internal State5_08게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격09 : TriggerState {
            internal State5스프링공격09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 112, 113, 115, 116, 117, 118, 119, 122, 124, 125, 127, 130, 131, 132, 133, 134, 136, 137, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 212, 213, 215, 216, 217, 218, 219, 222, 224, 225, 227, 230, 231, 232, 233, 234, 236, 237, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_09게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_09게임진행1 : TriggerState {
            internal State5_09게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격10 : TriggerState {
            internal State5스프링공격10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 106, 107, 110, 111, 112, 113, 114, 115, 118, 131, 134, 135, 136, 137, 138, 139, 142, 143, 144, 147, 148, 149, 150, 151, 152, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 206, 207, 210, 211, 212, 213, 214, 215, 218, 231, 234, 235, 236, 237, 238, 239, 242, 243, 244, 247, 248, 249, 250, 251, 252, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_10게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_10게임진행1 : TriggerState {
            internal State5_10게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격11 : TriggerState {
            internal State5스프링공격11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 112, 113, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 136, 137, 140, 141, 145, 146, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 212, 213, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 236, 237, 240, 241, 245, 246, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_11게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_11게임진행1 : TriggerState {
            internal State5_11게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격12 : TriggerState {
            internal State5스프링공격12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 107, 108, 113, 114, 115, 116, 119, 120, 125, 126, 127, 128, 131, 132, 138, 140, 142, 146, 147, 148, 149, 151, 153, 155, 157, 158, 159, 160}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 207, 208, 213, 214, 215, 216, 219, 220, 225, 226, 227, 228, 231, 232, 238, 240, 242, 246, 247, 248, 249, 251, 253, 255, 257, 258, 259, 260}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_12게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_12게임진행1 : TriggerState {
            internal State5_12게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격13 : TriggerState {
            internal State5스프링공격13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 105, 107, 109, 111, 113, 115, 117, 119, 121, 123, 125, 127, 129, 131, 133, 135, 137, 139, 141, 143, 145, 147, 149, 151, 153, 155, 157, 159, 161, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 205, 207, 209, 211, 213, 215, 217, 219, 221, 223, 225, 227, 229, 231, 233, 235, 237, 239, 241, 243, 245, 247, 249, 251, 253, 255, 257, 259, 261, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_13게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_13게임진행1 : TriggerState {
            internal State5_13게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격14 : TriggerState {
            internal State5스프링공격14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 106, 108, 109, 111, 114, 116, 117, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 132, 133, 135, 138, 139, 142, 143, 145, 146, 148, 150, 153, 154, 157, 159, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 206, 208, 209, 211, 214, 216, 217, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 232, 233, 235, 238, 239, 242, 243, 245, 246, 248, 250, 253, 254, 257, 259, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_14게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_14게임진행1 : TriggerState {
            internal State5_14게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격15 : TriggerState {
            internal State5스프링공격15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 105, 106, 109, 110, 111, 112, 115, 116, 117, 118, 119, 120, 123, 124, 125, 126, 127, 128, 131, 132, 133, 134, 137, 138, 140, 141, 143, 144, 145, 148, 149, 151, 153, 154, 156, 157, 158, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 205, 206, 209, 210, 211, 212, 215, 216, 217, 218, 219, 220, 223, 224, 225, 226, 227, 228, 231, 232, 233, 234, 237, 238, 240, 241, 243, 244, 245, 248, 249, 251, 253, 254, 256, 257, 258, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_15게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_15게임진행1 : TriggerState {
            internal State5_15게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격16 : TriggerState {
            internal State5스프링공격16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 140, 141, 145, 146, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 240, 241, 245, 246, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_16게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_16게임진행1 : TriggerState {
            internal State5_16게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격17 : TriggerState {
            internal State5스프링공격17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 116, 119, 120, 121, 122, 125, 126, 127, 128, 129, 130, 131, 132, 135, 136, 138, 139, 140, 142, 143, 146, 147, 148, 149, 151, 152, 153, 155, 156, 157, 158, 159, 160, 161, 162}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 211, 212, 213, 214, 215, 216, 219, 220, 221, 222, 225, 226, 227, 228, 229, 230, 231, 232, 235, 236, 238, 239, 240, 242, 243, 246, 247, 248, 249, 251, 252, 253, 255, 256, 257, 258, 259, 260, 261, 262}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_17게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_17게임진행1 : TriggerState {
            internal State5_17게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격18 : TriggerState {
            internal State5스프링공격18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 104, 105, 106, 107, 109, 110, 111, 113, 114, 116, 117, 118, 119, 121, 122, 123, 125, 126, 128, 129, 130, 131, 133, 134, 135, 138, 140, 142, 144, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 204, 205, 206, 207, 209, 210, 211, 213, 214, 216, 217, 218, 219, 221, 222, 223, 225, 226, 228, 229, 230, 231, 233, 234, 235, 238, 240, 242, 244, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_18게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_18게임진행1 : TriggerState {
            internal State5_18게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격19 : TriggerState {
            internal State5스프링공격19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 138, 139, 142, 143, 144, 145, 146, 147, 148, 150, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 238, 239, 242, 243, 244, 245, 246, 247, 248, 250, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_19게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_19게임진행1 : TriggerState {
            internal State5_19게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격20 : TriggerState {
            internal State5스프링공격20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 105, 106, 107, 108, 109, 110, 111, 112, 115, 116, 117, 118, 119, 121, 122, 123, 124, 125, 126, 127, 129, 130, 131, 132, 133, 134, 137, 138, 140, 141, 143, 144, 145, 146, 147, 148, 149, 150, 151, 153, 154, 156, 157, 158, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 205, 206, 207, 208, 209, 210, 211, 212, 215, 216, 217, 218, 219, 221, 222, 223, 224, 225, 226, 227, 229, 230, 231, 232, 233, 234, 237, 238, 240, 241, 243, 244, 245, 246, 247, 248, 249, 250, 251, 253, 254, 256, 257, 258, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_20게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_20게임진행1 : TriggerState {
            internal State5_20게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격21 : TriggerState {
            internal State5스프링공격21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 111, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 140, 141, 143, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 211, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 240, 241, 243, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_21게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_21게임진행1 : TriggerState {
            internal State5_21게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격22 : TriggerState {
            internal State5스프링공격22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 111, 112, 113, 114, 115, 116, 118, 119, 120, 121, 122, 123, 125, 126, 127, 128, 129, 130, 131, 132, 134, 135, 136, 138, 139, 140, 141, 142, 143, 145, 146, 147, 148, 149, 150, 151, 152, 153, 155, 156, 157, 158, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 211, 212, 213, 214, 215, 216, 218, 219, 220, 221, 222, 223, 225, 226, 227, 228, 229, 230, 231, 232, 234, 235, 236, 238, 239, 240, 241, 242, 243, 245, 246, 247, 248, 249, 250, 251, 252, 253, 255, 256, 257, 258, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_22게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_22게임진행1 : TriggerState {
            internal State5_22게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격23 : TriggerState {
            internal State5스프링공격23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_23게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_23게임진행1 : TriggerState {
            internal State5_23게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격24 : TriggerState {
            internal State5스프링공격24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 138, 139, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 238, 239, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_24게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_24게임진행1 : TriggerState {
            internal State5_24게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격25 : TriggerState {
            internal State5스프링공격25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 113, 114, 115, 116, 117, 118, 119, 120, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 144, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 215, 216, 217, 218, 219, 220, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 239, 240, 241, 242, 244, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_25게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_25게임진행1 : TriggerState {
            internal State5_25게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격26 : TriggerState {
            internal State5스프링공격26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 115, 116, 119, 120, 122, 124, 125, 127, 129, 130, 132, 133, 135, 136, 137, 138, 139, 142, 143, 144, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 215, 216, 219, 220, 222, 224, 225, 227, 229, 230, 232, 233, 235, 236, 237, 238, 239, 242, 243, 244, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_26게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_26게임진행1 : TriggerState {
            internal State5_26게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격27 : TriggerState {
            internal State5스프링공격27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113, 114, 116, 117, 120, 121, 122, 123, 124, 125, 126, 127, 130, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 145, 146, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 210, 211, 212, 213, 214, 216, 217, 220, 221, 222, 223, 224, 225, 226, 227, 230, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 245, 246, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_27게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_27게임진행1 : TriggerState {
            internal State5_27게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격28 : TriggerState {
            internal State5스프링공격28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 108, 109, 110, 111, 112, 113, 116, 118, 119, 120, 122, 123, 126, 127, 129, 130, 131, 133, 136, 137, 139, 140, 142, 145, 146, 147, 148, 149, 150, 151, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 208, 209, 210, 211, 212, 213, 216, 218, 219, 220, 222, 223, 226, 227, 229, 230, 231, 233, 236, 237, 239, 240, 242, 245, 246, 247, 248, 249, 250, 251, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_28게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_28게임진행1 : TriggerState {
            internal State5_28게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격29 : TriggerState {
            internal State5스프링공격29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 109, 110, 112, 113, 115, 117, 118, 119, 120, 122, 124, 125, 127, 129, 130, 131, 132, 134, 136, 137, 138, 143, 146, 147, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 209, 210, 212, 213, 215, 217, 218, 219, 220, 222, 224, 225, 227, 229, 230, 231, 232, 234, 236, 237, 238, 243, 246, 247, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_29게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_29게임진행1 : TriggerState {
            internal State5_29게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격30 : TriggerState {
            internal State5스프링공격30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 112, 113, 114, 115, 116, 117, 119, 121, 122, 123, 124, 125, 126, 127, 129, 130, 131, 132, 133, 135, 136, 137, 139, 140, 141, 142, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 212, 213, 214, 215, 216, 217, 219, 221, 222, 223, 224, 225, 226, 227, 229, 230, 231, 232, 233, 235, 236, 237, 239, 240, 241, 242, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_30게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_30게임진행1 : TriggerState {
            internal State5_30게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격31 : TriggerState {
            internal State5스프링공격31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 113, 115, 116, 117, 118, 119, 120, 121, 123, 124, 125, 126, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 213, 215, 216, 217, 218, 219, 220, 221, 223, 224, 225, 226, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_31게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_31게임진행1 : TriggerState {
            internal State5_31게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격32 : TriggerState {
            internal State5스프링공격32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 131, 132, 133, 134, 135, 136, 137, 138, 140, 141, 143, 144, 145, 146, 147, 148, 149, 150, 152, 153, 154, 155, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 231, 232, 233, 234, 235, 236, 237, 238, 240, 241, 243, 244, 245, 246, 247, 248, 249, 250, 252, 253, 254, 255, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_32게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_32게임진행1 : TriggerState {
            internal State5_32게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격33 : TriggerState {
            internal State5스프링공격33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 105, 106, 107, 108, 109, 111, 112, 113, 115, 116, 117, 118, 119, 120, 121, 122, 123, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 156, 157, 158, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 205, 206, 207, 208, 209, 211, 212, 213, 215, 216, 217, 218, 219, 220, 221, 222, 223, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 256, 257, 258, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_33게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_33게임진행1 : TriggerState {
            internal State5_33게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격34 : TriggerState {
            internal State5스프링공격34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 110, 111, 112, 113, 114, 116, 118, 119, 121, 122, 123, 124, 125, 126, 127, 128, 130, 131, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 210, 211, 212, 213, 214, 216, 218, 219, 221, 222, 223, 224, 225, 226, 227, 228, 230, 231, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_34게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_34게임진행1 : TriggerState {
            internal State5_34게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격35 : TriggerState {
            internal State5스프링공격35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 116, 117, 118, 122, 123, 126, 127, 128, 129, 130, 131, 132, 133, 134, 136, 137, 138, 139, 140, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 216, 217, 218, 222, 223, 226, 227, 228, 229, 230, 231, 232, 233, 234, 236, 237, 238, 239, 240, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_35게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_35게임진행1 : TriggerState {
            internal State5_35게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격36 : TriggerState {
            internal State5스프링공격36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 153, 154, 155, 156, 158, 159, 160, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 253, 254, 255, 256, 258, 259, 260, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_36게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_36게임진행1 : TriggerState {
            internal State5_36게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격37 : TriggerState {
            internal State5스프링공격37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 116, 117, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 216, 217, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 232, 233, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_37게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_37게임진행1 : TriggerState {
            internal State5_37게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격38 : TriggerState {
            internal State5스프링공격38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 159, 160, 161, 162, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 259, 260, 261, 262, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_38게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_38게임진행1 : TriggerState {
            internal State5_38게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격39 : TriggerState {
            internal State5스프링공격39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 130, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 144, 145, 146, 147, 149, 150, 151, 152, 153, 154, 155, 156, 158, 159, 160, 161, 162, 163}, enabled: true);
                context.SetSkill(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 230, 232, 233, 235, 236, 237, 238, 239, 240, 241, 242, 244, 245, 246, 247, 249, 250, 251, 252, 253, 254, 255, 256, 258, 259, 260, 261, 262, 263}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_39게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_39게임진행1 : TriggerState {
            internal State5_39게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5스프링공격40 : TriggerState {
            internal State5스프링공격40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "99", seconds: 2);
                context.SetBreakable(triggerIds: new []{102, 103, 104, 105, 106, 107, 108, 109, 110, 112, 113, 114, 116, 117, 119, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, enabled: true);
                context.SetSkill(triggerIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 216, 217, 219, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "99")) {
                    return new State5_40게임진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5_40게임진행1 : TriggerState {
            internal State5_40게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "98", seconds: 1);
                context.SetBreakable(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "98")) {
                    return new State공격중지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
