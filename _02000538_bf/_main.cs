using System;

namespace Maple2.Trigger._02000538_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5000}, arg2: false);
                context.SetSkill(arg1: new int[] {9001}, arg2: false);
                context.SetSkill(arg1: new int[] {9002}, arg2: false);
                context.SetSkill(arg1: new int[] {9003}, arg2: false);
                context.SetSkill(arg1: new int[] {9004}, arg2: false);
                context.SetSkill(arg1: new int[] {9005}, arg2: false);
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 2, isEnable: false);
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 104, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 105, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(arg1: new int[] {108}, arg2: true);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "801", arg2: 0)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5000}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02000538_BF__MAIN__0$", arg3: new int[] {3000});
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateready2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready2 : TriggerState {
            internal Stateready2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {108});
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 4000,
                    script: "$02000538_BF__MAIN__1$");
                context.CreateMonster(arg1: new int[] {101, 1011, 1012, 1013, 1014}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101, 1011, 1012, 1013, 1014})) {
                    context.State = new State방으로이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State방으로이동 : TriggerState {
            internal State방으로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1081}, arg2: true);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000538_BF__MAIN__2$");
                context.CreateMonster(arg1: new int[] {1015, 1016, 1017}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "802", arg2: 0)) {
                    context.State = new State방몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State방몬스터생성 : TriggerState {
            internal State방몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102, 1021, 1022}, arg2: true);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000538_BF__MAIN__3$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102, 1021, 1022, 1015, 1016, 1017})) {
                    context.State = new State첫번째전투판파괴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째전투판파괴 : TriggerState {
            internal State첫번째전투판파괴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1081});
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetSkill(arg1: new int[] {9001}, arg2: true);
                context.EnableSpawnPointPc(spawnPointID: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: true);
                context.CreateMonster(arg1: new int[] {1023, 1024}, arg2: true);
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 4000,
                    script: "$02000538_BF__MAIN__4$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "803", arg2: 0)) {
                    context.State = new State세번째판몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째판몬스터생성 : TriggerState {
            internal State세번째판몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {103, 1031, 1032, 1033}, arg2: true);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000538_BF__MAIN__5$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {103, 1031, 1032, 1033, 1023, 1024})) {
                    context.State = new State몬스터추가생성감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터추가생성감지 : TriggerState {
            internal State몬스터추가생성감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "804", arg2: 0)) {
                    context.State = new State몬스터추가생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터추가생성 : TriggerState {
            internal State몬스터추가생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 4000,
                    script: "$02000538_BF__MAIN__6$");
                context.CreateMonster(arg1: new int[] {104, 1041, 1042, 1043, 1044}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {104, 1041, 1042, 1043, 1044})) {
                    context.State = new State몬스터추가생성2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터추가생성2 : TriggerState {
            internal State몬스터추가생성2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {107, 1071}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {107, 1071})) {
                    context.State = new State세번째전투판파괴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째전투판파괴 : TriggerState {
            internal State세번째전투판파괴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetSkill(arg1: new int[] {9003}, arg2: true);
                context.SideNpcTalk(npcID: 11004644, illust: "SlaveMan3_normal", duration: 4000,
                    script: "$02000538_BF__MAIN__7$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State다섯번째판몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다섯번째판몬스터생성 : TriggerState {
            internal State다섯번째판몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1082}, arg2: true);
                context.EnableSpawnPointPc(spawnPointID: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 2, isEnable: true);
                context.CreateMonster(arg1: new int[] {105, 1051, 1052, 1053, 1054, 1055}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {105, 1051, 1052, 1053, 1054, 1055})) {
                    context.State = new State엘리트소환체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리트소환체크 : TriggerState {
            internal State엘리트소환체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "806", arg2: 0)) {
                    context.State = new State엘리트소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리트소환 : TriggerState {
            internal State엘리트소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5000}, arg2: true);
                context.DestroyMonster(arg1: new int[] {1082});
                context.SetOnetimeEffect(id: 104, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(arg1: new int[] {106}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {106})) {
                    context.State = new State마지막전투판파괴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막전투판파괴 : TriggerState {
            internal State마지막전투판파괴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004643, illust: "SlaveWoman3_normal", duration: 4000,
                    script: "$02000538_BF__MAIN__8$");
                context.LockMyPc(isLock: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetOnetimeEffect(id: 105, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State마지막전투판파괴2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막전투판파괴2 : TriggerState {
            internal State마지막전투판파괴2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: false);
                context.SetSkill(arg1: new int[] {9005}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {
                        601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619,
                        620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638,
                        639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650, 651, 652, 653, 654, 655, 656, 657,
                        658, 659, 660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 670, 671, 672, 673, 674, 675, 676,
                        677, 678, 679, 680, 681, 682, 683, 684, 685, 686, 687, 688, 689, 690, 691, 692, 693, 694, 695,
                        696, 697, 698, 699, 700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714,
                        715, 716, 717, 718, 719, 720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733,
                        734, 735, 736, 737, 738, 739, 740, 741, 742, 743, 744, 745, 746, 747, 748, 749, 750, 751, 752,
                        753, 754, 755, 756, 757, 758, 759, 760, 761, 762, 763, 764, 765, 766, 767
                    }, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}