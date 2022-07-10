namespace Maple2.Trigger._02100000_bf {
    public static class _timer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 19, visible: false, enabled: false, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new State타이머시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10000", seconds: 360, clearAtZero: true, display: true, arg5: 0);
            }

            public override TriggerState? Execute() {
                return new StateUserDetection_2(context);
            }

            public override void OnExit() { }
        }

        private class StateUserDetection_2 : TriggerState {
            internal StateUserDetection_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new StateMonsterSpawn_Boss(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_Boss : TriggerState {
            internal StateMonsterSpawn_Boss(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{82001}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd선택(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd선택 : TriggerState {
            internal StateEnd선택(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{82001})) {
                    return new StateSuccess(context);
                }

                if (context.TimeExpired(timerId: "10000")) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "10000");
            }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "Find02100000");
                context.SetEventUI(arg1: 7, script: "$02100000_BF__TIMER__1$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DungeonClear();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, script: "$02100000_BF__TIMER__0$", duration: 2000, boxId: 0);
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DungeonFail();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 19, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
