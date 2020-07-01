namespace Maple2.Trigger._52010027_qd {
    public static class _main_quest10003102 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003102}, arg3: new byte[] {1})) {
                    return new StateDel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDel : TriggerState {
            internal StateDel(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52010027, arg2: 6007);
                context.CreateMonster(arg1: new[] {803}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 803, arg2: "Stun_A", arg3: 160000000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State엔피씨와말을걸면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔피씨와말을걸면 : TriggerState {
            internal State엔피씨와말을걸면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4013}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State보스몬스터는소멸준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스몬스터는소멸준비 : TriggerState {
            internal State보스몬스터는소멸준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "완료조건", arg2: "exit");
                context.AddCinematicTalk(npcId: 11003469, msg: "$52010027_QD__MAIN_QUEST10003102__0$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003469, msg: "$52010027_QD__MAIN_QUEST10003102__1$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State보스몬스터는소멸준비01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스몬스터는소멸준비01 : TriggerState {
            internal State보스몬스터는소멸준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4014}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN_QUEST10003102__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN_QUEST10003102__3$", duration: 3000);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 10000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State보스몬스터는소멸준비02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스몬스터는소멸준비02 : TriggerState {
            internal State보스몬스터는소멸준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4013}, arg2: false);
                context.AddCinematicTalk(npcId: 11003469, msg: "$52010027_QD__MAIN_QUEST10003102__4$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003469, msg: "$52010027_QD__MAIN_QUEST10003102__5$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003469, msg: "$52010027_QD__MAIN_QUEST10003102__6$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State보스몬스터는소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스몬스터는소멸 : TriggerState {
            internal State보스몬스터는소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State보스몬스터는소멸_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스몬스터는소멸_01 : TriggerState {
            internal State보스몬스터는소멸_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {803});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료 : TriggerState {
            internal State전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4014}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN_QUEST10003102__7$", duration: 2000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN_QUEST10003102__8$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, msg: "$52010027_QD__MAIN_QUEST10003102__9$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State전투종료01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료01 : TriggerState {
            internal State전투종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전투종료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료02 : TriggerState {
            internal State전투종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State완료조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료조건 : TriggerState {
            internal State완료조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "WindValleyBattle");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000051, arg2: 3);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}