namespace Maple2.Trigger._52020027_qd {
    public static class _52020027_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "Boss", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new StateCinematic감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic감지 : TriggerState {
            internal StateCinematic감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    return new StateCamera_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_시작 : TriggerState {
            internal StateCamera_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateCamera_종료(context), arg2: "exit");
                context.MoveUser(mapId: 52020027, portalId: 2);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Sit_Down_A", duration: 5000f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 501, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_세리하Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_세리하Script1 : TriggerState {
            internal StateCamera_세리하Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 22000114, script: "대체 어딨는거지?", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_세리하Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_세리하Script2 : TriggerState {
            internal StateCamera_세리하Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 502, enabled: true);
                context.SetNpcRotation(spawnId: 101, rotation: 180);
                context.SetConversation(type: 2, spawnId: 22000114, script: "여기까지 쫓아왔어?", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_세리하Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_세리하Script3 : TriggerState {
            internal StateCamera_세리하Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 22000114, script: "이제 결판을 내자!!", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_종료 : TriggerState {
            internal StateCamera_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CameraReset(interpolationTime: 0.1f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateBoss시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss시작 : TriggerState {
            internal StateBoss시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111}, arg2: true);
                context.SetUserValue(triggerId: 99990002, key: "Boss", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111})) {
                    return new StateBoss종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss종료 : TriggerState {
            internal StateBoss종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetAchievement(triggerId: 904, type: "trigger", code: "KritiasScrimmage");
                context.SetEventUI(arg1: 1, script: "연출들어갈 예정입니다", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02020006, portalId: 6001);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
