namespace Maple2.Trigger._52000020_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{60001022}, questStates: new byte[]{1})) {
                    return new StateCamera_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_01 : TriggerState {
            internal StateCamera_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateMonster_spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster_spawn_01 : TriggerState {
            internal StateMonster_spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{111, 112, 113, 114}, arg2: true);
                context.SetConversation(type: 1, spawnId: 111, script: "$52000020_QD__MAIN__2$", arg4: 5);
                context.SetConversation(type: 1, spawnId: 112, script: "$52000020_QD__MAIN__3$", arg4: 5);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateBattle_01(context);
                }

                if (context.MonsterDead(spawnIds: new []{111, 112, 113, 114})) {
                    return new StateCamera_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateBattle_01 : TriggerState {
            internal StateBattle_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111, 112, 113, 114})) {
                    return new StateCamera_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class StateCamera_02 : TriggerState {
            internal StateCamera_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "1", seconds: 1);
                context.CameraSelectPath(pathIds: new []{8003, 8004}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateMonster_spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster_spawn_02 : TriggerState {
            internal StateMonster_spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{121, 122, 123, 124, 125, 126}, arg2: true);
                context.SetConversation(type: 1, spawnId: 121, script: "$52000020_QD__MAIN__4$", arg4: 5);
                context.SetConversation(type: 1, spawnId: 124, script: "$52000020_QD__MAIN__5$", arg4: 5);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateBattle_02(context);
                }

                if (context.MonsterDead(spawnIds: new []{121, 122, 123, 124, 125, 126})) {
                    return new StateCamera_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateBattle_02 : TriggerState {
            internal StateBattle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{121, 122, 123, 124, 125, 126})) {
                    return new StateCamera_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class StateCamera_03 : TriggerState {
            internal StateCamera_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "1", seconds: 1);
                context.CameraSelectPath(pathIds: new []{8005, 8006}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateMonster_spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster_spawn_03 : TriggerState {
            internal StateMonster_spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{131, 132, 133, 134, 135, 136}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateBattle_03(context);
                }

                if (context.MonsterDead(spawnIds: new []{131, 132, 133, 134, 135, 136})) {
                    return new StateComplete(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetConversation(type: 1, spawnId: 131, script: "$52000020_QD__MAIN__1$", arg4: 5);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateBattle_03 : TriggerState {
            internal StateBattle_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{131, 132, 133, 134, 135, 136})) {
                    return new StateComplete(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class StateComplete : TriggerState {
            internal StateComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
