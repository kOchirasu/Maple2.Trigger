namespace Maple2.Trigger._02000538_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5000}, visible: false);
                context.SetSkill(triggerIds: new []{9001, 9002, 9003, 9004, 9005}, enabled: false);
                context.EnableSpawnPointPc(spawnId: 0, enabled: true);
                context.EnableSpawnPointPc(spawnId: 1, enabled: false);
                context.EnableSpawnPointPc(spawnId: 2, enabled: false);
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 104, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 105, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(spawnIds: new []{108}, arg2: true);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{801}, jobCode: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5000}, visible: false);
                context.SetEventUI(arg1: 1, script: "$02000538_BF__MAIN__0$", duration: 3000);
                context.SetOnetimeEffect(id: 102, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateReady2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady2 : TriggerState {
            internal StateReady2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{108});
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "$02000538_BF__MAIN__1$");
                context.CreateMonster(spawnIds: new []{101, 1011, 1012, 1013, 1014}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 1011, 1012, 1013, 1014})) {
                    return new State방으로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방으로이동 : TriggerState {
            internal State방으로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1081}, arg2: true);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000538_BF__MAIN__2$");
                context.CreateMonster(spawnIds: new []{1015, 1016, 1017}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{802}, jobCode: 0)) {
                    return new State방MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방MonsterCreation : TriggerState {
            internal State방MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102, 1021, 1022}, arg2: true);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000538_BF__MAIN__3$");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102, 1021, 1022, 1015, 1016, 1017})) {
                    return new State첫번째전투판파괴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째전투판파괴 : TriggerState {
            internal State첫번째전투판파괴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1081});
                context.SetOnetimeEffect(id: 101, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetSkill(triggerIds: new []{9001}, enabled: true);
                context.EnableSpawnPointPc(spawnId: 0, enabled: false);
                context.EnableSpawnPointPc(spawnId: 1, enabled: true);
                context.CreateMonster(spawnIds: new []{1023, 1024}, arg2: true);
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "$02000538_BF__MAIN__4$");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{803}, jobCode: 0)) {
                    return new State세번째판MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째판MonsterCreation : TriggerState {
            internal State세번째판MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103, 1031, 1032, 1033}, arg2: true);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000538_BF__MAIN__5$");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{103, 1031, 1032, 1033, 1023, 1024})) {
                    return new StateMonster추가Creation감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster추가Creation감지 : TriggerState {
            internal StateMonster추가Creation감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{804}, jobCode: 0)) {
                    return new StateMonster추가Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster추가Creation : TriggerState {
            internal StateMonster추가Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "$02000538_BF__MAIN__6$");
                context.CreateMonster(spawnIds: new []{104, 1041, 1042, 1043, 1044}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{104, 1041, 1042, 1043, 1044})) {
                    return new StateMonster추가Creation2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster추가Creation2 : TriggerState {
            internal StateMonster추가Creation2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{107, 1071}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{107, 1071})) {
                    return new State세번째전투판파괴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째전투판파괴 : TriggerState {
            internal State세번째전투판파괴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 103, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetSkill(triggerIds: new []{9003}, enabled: true);
                context.SideNpcTalk(npcId: 11004644, illust: "SlaveMan3_normal", duration: 4000, script: "$02000538_BF__MAIN__7$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다섯번째판MonsterCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯번째판MonsterCreation : TriggerState {
            internal State다섯번째판MonsterCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1082}, arg2: true);
                context.EnableSpawnPointPc(spawnId: 1, enabled: false);
                context.EnableSpawnPointPc(spawnId: 2, enabled: true);
                context.CreateMonster(spawnIds: new []{105, 1051, 1052, 1053, 1054, 1055}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{105, 1051, 1052, 1053, 1054, 1055})) {
                    return new StateEliteSummonCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEliteSummonCheck : TriggerState {
            internal StateEliteSummonCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{806}, jobCode: 0)) {
                    return new StateElite소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateElite소환 : TriggerState {
            internal StateElite소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{5000}, visible: true);
                context.DestroyMonster(spawnIds: new []{1082});
                context.SetOnetimeEffect(id: 104, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CreateMonster(spawnIds: new []{106}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{106})) {
                    return new State마지막전투판파괴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막전투판파괴 : TriggerState {
            internal State마지막전투판파괴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004643, illust: "SlaveWoman3_normal", duration: 4000, script: "$02000538_BF__MAIN__8$");
                context.LockMyPc(isLock: true);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetOnetimeEffect(id: 105, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마지막전투판파괴2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막전투판파괴2 : TriggerState {
            internal State마지막전투판파괴2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: false);
                context.SetSkill(triggerIds: new []{9005}, enabled: true);
                context.SetMesh(triggerIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650, 651, 652, 653, 654, 655, 656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 670, 671, 672, 673, 674, 675, 676, 677, 678, 679, 680, 681, 682, 683, 684, 685, 686, 687, 688, 689, 690, 691, 692, 693, 694, 695, 696, 697, 698, 699, 700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721, 722, 723, 724, 725, 726, 727, 728, 729, 730, 731, 732, 733, 734, 735, 736, 737, 738, 739, 740, 741, 742, 743, 744, 745, 746, 747, 748, 749, 750, 751, 752, 753, 754, 755, 756, 757, 758, 759, 760, 761, 762, 763, 764, 765, 766, 767}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
