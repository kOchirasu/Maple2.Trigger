using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010032_qd {
    public static class _main_quest10003078 {
        public class State무르파고스에들어오면 : TriggerState {
            internal State무르파고스에들어오면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003078}, arg3: new byte[] {2})) {
                    context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(arg1: new[] {301, 302}, arg2: true);
                context.MoveUser(arg1: 52010032, arg2: 6001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State무르파고스이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무르파고스이동 : TriggerState {
            internal State무르파고스이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State무르파고스이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무르파고스이동01 : TriggerState {
            internal State무르파고스이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUserPath(arg1: "MS2PatrolData_3005");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_3004");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010032_QD__MAIN_QUEST10003078__0$", script: "$52010032_QD__MAIN_QUEST10003078__1$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2f);
                context.AddBalloonTalk(spawnPointId: 301, msg: "$52010032_QD__MAIN_QUEST10003078__2$", duration: 2000, delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 302, msg: "$52010032_QD__MAIN_QUEST10003078__3$", duration: 2000, delayTick: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State나메드에게Quest받기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나메드에게Quest받기 : TriggerState {
            internal State나메드에게Quest받기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}