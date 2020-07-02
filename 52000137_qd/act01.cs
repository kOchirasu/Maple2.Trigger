namespace Maple2.Trigger._52000137_qd {
    public static class _act01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7000}, arg2: false);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 201, 202, 203, 301, 900, 910, 920});
                context.SetEffect(arg1: new[] {5100, 5101, 5200, 5300, 5400, 5401, 5500, 5501}, arg2: false);
                context.SetEffect(arg1: new[] {5600}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetUserValue(key: "PatosTired", value: 0);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {1})) {
                    return new StateLodingDelay01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {2})) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 201, 910, 920}, arg2: true);
                context.SetEffect(arg1: new[] {5100, 5101}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateSetMaskEffect01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetMaskEffect01 : TriggerState {
            internal StateSetMaskEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 4);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetMaskEffect02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetMaskEffect02 : TriggerState {
            internal StateSetMaskEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateImprisonDarkAnos01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateImprisonDarkAnos01 : TriggerState {
            internal StateImprisonDarkAnos01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateImprisonDarkAnos02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateImprisonDarkAnos02 : TriggerState {
            internal StateImprisonDarkAnos02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAsimovTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAsimovTalk01 : TriggerState {
            internal StateAsimovTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003283, msg: "$52000137_QD__ACT01__0$", duration: 5000, align: "center", illustId: "0");
                context.SetSceneSkip(arg1: "DarkAnosTalk01CSkip", arg2: "nextState");
                context.SetSkip(arg1: "AsimovTalk01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateAsimovTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAsimovTalk01Skip : TriggerState {
            internal StateAsimovTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateZoominAnos01(context);
            }

            public override void OnExit() { }
        }

        private class StateZoominAnos01 : TriggerState {
            internal StateZoominAnos01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 602, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateAnosTruning01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAnosTruning01 : TriggerState {
            internal StateAnosTruning01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5500}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAnosTruning02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAnosTruning02 : TriggerState {
            internal StateAnosTruning02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateAnosTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAnosTalk01 : TriggerState {
            internal StateAnosTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003289, msg: "$52000137_QD__ACT01__1$", duration: 4000, align: "center", illustId: "0");
                context.SetSkip(arg1: "AnosTalk01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateAnosTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAnosTalk01Skip : TriggerState {
            internal StateAnosTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateCameraChange00(context);
            }

            public override void OnExit() { }
        }

        private class StateCameraChange00 : TriggerState {
            internal StateCameraChange00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 603, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange01 : TriggerState {
            internal StateCameraChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTalk01 : TriggerState {
            internal StatePCTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 4000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000137_QD__ACT01__2$", duration: 4000, align: "center", illustId: "0");
                context.SetSkip(arg1: "PCTalk01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTalk01Skip : TriggerState {
            internal StatePCTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateAsimovTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateAsimovTalk02 : TriggerState {
            internal StateAsimovTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003283, msg: "$52000137_QD__ACT01__3$", duration: 4000, align: "center", illustId: "Asimov_normal");
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.SetSkip(arg1: "AsimovTalk02Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateAsimovTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAsimovTalk02Skip : TriggerState {
            internal StateAsimovTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateAsimovTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateAsimovTalk03 : TriggerState {
            internal StateAsimovTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003283, msg: "$52000137_QD__ACT01__4$", duration: 5000, align: "center", illustId: "Asimov_normal");
                context.SetSkip(arg1: "AsimovTalk03Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateAsimovTalk03Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAsimovTalk03Skip : TriggerState {
            internal StateAsimovTalk03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateCameraChange02(context);
            }

            public override void OnExit() { }
        }

        private class StateCameraChange02 : TriggerState {
            internal StateCameraChange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraChange03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange03 : TriggerState {
            internal StateCameraChange03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 604, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTalk02 : TriggerState {
            internal StatePCTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000137_QD__ACT01__5$", duration: 5000, align: "center", illustId: "0");
                context.SetSkip(arg1: "PCTalk02Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePCTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTalk02Skip : TriggerState {
            internal StatePCTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateCameraChange04(context);
            }

            public override void OnExit() { }
        }

        private class StateCameraChange04 : TriggerState {
            internal StateCameraChange04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {103});
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.CameraSelect(arg1: 605, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDarkAnosTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosTalk01 : TriggerState {
            internal StateDarkAnosTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Attack_Idle_A,Attack_Idle_A");
                context.AddCinematicTalk(npcId: 11003285, msg: "$52000137_QD__ACT01__6$", duration: 3000, align: "center", illustId: "Patos_normal");
                context.SetSkip(arg1: "DarkAnosTalk01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3100)) {
                    return new StateDarkAnosTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosTalk01Skip : TriggerState {
            internal StateDarkAnosTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateDarkAnosAttackAsimov01(context);
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosAttackAsimov01 : TriggerState {
            internal StateDarkAnosAttackAsimov01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 610, arg2: true);
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Attack_01_A,Attack_Idle_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDarkAnosAttackAsimov02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosAttackAsimov02 : TriggerState {
            internal StateDarkAnosAttackAsimov02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5200}, arg2: true);
                context.DestroyMonster(arg1: new[] {201, 910, 920});
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.SetEffect(arg1: new[] {5501}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDarkAnosAttackAsimov03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosAttackAsimov03 : TriggerState {
            internal StateDarkAnosAttackAsimov03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5500, 5101, 5100}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraChange05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange05 : TriggerState {
            internal StateCameraChange05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 611, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_1003");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000137_QD__ACT01__7$", duration: 2000, delayTick: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraChange06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange06 : TriggerState {
            internal StateCameraChange06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetEffect(arg1: new[] {5501}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraChange07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange07 : TriggerState {
            internal StateCameraChange07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 612, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateAsimovTalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAsimovTalk04 : TriggerState {
            internal StateAsimovTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003283, msg: "$52000137_QD__ACT01__8$", duration: 5000, align: "center", illustId: "Asimov_normal");
                context.SetSkip(arg1: "AsimovTalk04Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateAsimovTalk04Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAsimovTalk04Skip : TriggerState {
            internal StateAsimovTalk04Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Event_02_A,Down_Idle_A,Down_Idle_A,Down_Idle_A,Down_Idle_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateAsimovFaint01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAsimovFaint01 : TriggerState {
            internal StateAsimovFaint01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAsimovFaint02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAsimovFaint02 : TriggerState {
            internal StateAsimovFaint02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {203}, arg2: false);
                context.CameraSelect(arg1: 613, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAsimovFaint03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAsimovFaint03 : TriggerState {
            internal StateAsimovFaint03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDarkAnosApproach01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosApproach01 : TriggerState {
            internal StateDarkAnosApproach01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_104");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDarkAnosApproach02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosApproach02 : TriggerState {
            internal StateDarkAnosApproach02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDarkAnosTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosTalk02 : TriggerState {
            internal StateDarkAnosTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003285, msg: "$52000137_QD__ACT01__9$", duration: 5000, align: "center", illustId: "Patos_normal");
                context.SetSkip(arg1: "DarkAnosTalk02Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDarkAnosTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosTalk02Skip : TriggerState {
            internal StateDarkAnosTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StatePCTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StatePCTalk03 : TriggerState {
            internal StatePCTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 4000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000137_QD__ACT01__10$", duration: 5000, align: "center", illustId: "0");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePCTalk03Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTalk03Skip : TriggerState {
            internal StatePCTalk03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateDarkAnosTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosTalk03 : TriggerState {
            internal StateDarkAnosTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003285, msg: "$52000137_QD__ACT01__11$", duration: 4000, align: "center", illustId: "Patos_normal");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDarkAnosTalk03Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosTalk01CSkip : TriggerState {
            internal StateDarkAnosTalk01CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 201, 910, 920});
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {203}, arg2: false);
                context.SetEffect(arg1: new[] {5500, 5501, 5100, 5101, 5200}, arg2: false);
                context.SetPcEmotionSequence(arg1: "Attack_Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateDarkAnosTalk03Skip(context);
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosTalk03Skip : TriggerState {
            internal StateDarkAnosTalk03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDarkAnosBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosBattle01 : TriggerState {
            internal StateDarkAnosBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDarkAnosBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosBattle02 : TriggerState {
            internal StateDarkAnosBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
                context.CreateMonster(arg1: new[] {900}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PatosTired") == 1) {
                    return new StateDarkAnosDown01(context);
                }

                if (context.MonsterDead(arg1: new[] {900})) {
                    return new StateDarkAnosDown01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkAnosDown01 : TriggerState {
            internal StateDarkAnosDown01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePositionArrange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePositionArrange01 : TriggerState {
            internal StatePositionArrange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {900});
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.MoveUser(arg1: 52000137, arg2: 10, arg3: 9900);
                context.CameraSelect(arg1: 620, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePositionArrange02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePositionArrange02 : TriggerState {
            internal StatePositionArrange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCBalloonTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCBalloonTalk01 : TriggerState {
            internal StatePCBalloonTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2000");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000137_QD__ACT01__12$", duration: 2000, delayTick: 500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCBalloonTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCBalloonTalk02 : TriggerState {
            internal StatePCBalloonTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000137_QD__ACT01__13$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCBalloonTalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCBalloonTalk03 : TriggerState {
            internal StatePCBalloonTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 621, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateKanduraApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraApp01 : TriggerState {
            internal StateKanduraApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 622, arg2: true);
                context.CreateMonster(arg1: new[] {301}, arg2: false);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateKanduraApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraApp02 : TriggerState {
            internal StateKanduraApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000137_QD__ACT01__14$", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateKanduraApp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraApp03 : TriggerState {
            internal StateKanduraApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateKanduraAttack01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAttack01 : TriggerState {
            internal StateKanduraAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 623, arg2: true);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Event_01_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateKanduraAttack02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAttack02 : TriggerState {
            internal StateKanduraAttack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraChange10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange10 : TriggerState {
            internal StateCameraChange10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraChange11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange11 : TriggerState {
            internal StateCameraChange11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 630, arg2: true);
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 30000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraChange12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraChange12 : TriggerState {
            internal StateCameraChange12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateKanduraTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraTalk01 : TriggerState {
            internal StateKanduraTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_302");
                context.AddCinematicTalk(npcId: 11003287, msg: "$52000137_QD__ACT01__15$", duration: 4000, align: "center", illustId: "Kandura_normal");
                context.SetSceneSkip(arg1: "ShowCaption04Skip", arg2: "exit");
                context.SetSkip(arg1: "KanduraTalk01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraTalk01Skip : TriggerState {
            internal StateKanduraTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StatePCTalk04(context);
            }

            public override void OnExit() { }
        }

        private class StatePCTalk04 : TriggerState {
            internal StatePCTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000137_QD__ACT01__16$", duration: 4000, align: "center", illustId: "0");
                context.SetSkip(arg1: "PCTalk04Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCTalk04Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTalk04Skip : TriggerState {
            internal StatePCTalk04Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateKanduraMoveToDarkAnos01(context);
            }

            public override void OnExit() { }
        }

        private class StateKanduraMoveToDarkAnos01 : TriggerState {
            internal StateKanduraMoveToDarkAnos01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 631, arg2: true);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_303");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateKanduraTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraTalk02 : TriggerState {
            internal StateKanduraTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003287, msg: "$52000137_QD__ACT01__17$", duration: 4000, align: "center", illustId: "Kandura_normal");
                context.SetSkip(arg1: "KanduraTalk02Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraTalk02Skip : TriggerState {
            internal StateKanduraTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateKanduraReadyToDisapp01(context);
            }

            public override void OnExit() { }
        }

        private class StateKanduraReadyToDisapp01 : TriggerState {
            internal StateKanduraReadyToDisapp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 632, arg2: true);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Event_02_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateKanduraReadyToDisapp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraReadyToDisapp02 : TriggerState {
            internal StateKanduraReadyToDisapp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5300, 5400}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateKanduraReadyToDisapp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraReadyToDisapp03 : TriggerState {
            internal StateKanduraReadyToDisapp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5400}, arg2: false);
                context.SetEffect(arg1: new[] {5401}, arg2: true);
                context.DestroyMonster(arg1: new[] {105, 301});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKanduraReadyToDisapp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraReadyToDisapp04 : TriggerState {
            internal StateKanduraReadyToDisapp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateShowCaption01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption01 : TriggerState {
            internal StateShowCaption01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateShowCaption02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02 : TriggerState {
            internal StateShowCaption02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000137_QD__ACT01__18$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateShowCaption02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption02Skip : TriggerState {
            internal StateShowCaption02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateShowCaption03(context);
            }

            public override void OnExit() { }
        }

        private class StateShowCaption03 : TriggerState {
            internal StateShowCaption03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000137_QD__ACT01__19$");
                context.SetSkip(arg1: "ShowCaption03Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateShowCaption03Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption03Skip : TriggerState {
            internal StateShowCaption03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                return new StateShowCaption04(context);
            }

            public override void OnExit() { }
        }

        private class StateShowCaption04 : TriggerState {
            internal StateShowCaption04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 9, arg2: "$52000137_QD__ACT01__20$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateShowCaption04Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption04Skip : TriggerState {
            internal StateShowCaption04Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateQuit01(context);
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "AsimovRetire");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.MoveUser(arg1: 02000035, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}