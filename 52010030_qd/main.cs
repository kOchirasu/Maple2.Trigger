using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010030_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001})) {
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
                context.SetCinematicUI(type: 4);
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에바고르_독백_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르_독백_01 : TriggerState {
            internal State에바고르_독백_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Down_Idle_A", duration: 200000f);
                context.SetCinematicUI(type: 9, script: "$52010030_QD__MAIN__0$", arg3: false);
                context.SetSceneSkip(state: new StateEnd(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에바고르_독백_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르_독백_02 : TriggerState {
            internal State에바고르_독백_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52010030_QD__MAIN__1$", arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에바고르_독백_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르_독백_02_01 : TriggerState {
            internal State에바고르_독백_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52010030_QD__MAIN__2$", arg3: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에바고르_독백_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르_독백_03 : TriggerState {
            internal State에바고르_독백_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52010030_QD__MAIN__3$", arg3: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에바고르_독백_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르_독백_04 : TriggerState {
            internal State에바고르_독백_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52010030_QD__MAIN__4$", arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에바고르_좌절_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르_좌절_01 : TriggerState {
            internal State에바고르_좌절_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4004, 4001}, returnView: false);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010030_QD__MAIN__5$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에바고르_좌절_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르_좌절_02 : TriggerState {
            internal State에바고르_좌절_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003470, script: "$52010030_QD__MAIN__6$", duration: 2000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003470, script: "$52010030_QD__MAIN__7$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에바고르_좌절_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르_좌절_03 : TriggerState {
            internal State에바고르_좌절_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Attack_Idle_A", duration: 200000f);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010030_QD__MAIN__8$", duration: 2000, align: Align.Left);
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State뮤테라피온_Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뮤테라피온_Spawn_01 : TriggerState {
            internal State뮤테라피온_Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.AddCinematicTalk(npcId: 11003470, script: "$52010030_QD__MAIN__9$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State뮤테라피온_Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뮤테라피온_Spawn_02 : TriggerState {
            internal State뮤테라피온_Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2002, 4003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003470, script: "$52010030_QD__MAIN__10$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State잠시뒤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시뒤 : TriggerState {
            internal State잠시뒤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52010030_QD__MAIN__11$", arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State잠시뒤_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시뒤_1 : TriggerState {
            internal State잠시뒤_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000146, portalId: 3);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
