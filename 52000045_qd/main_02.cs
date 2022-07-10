namespace Maple2.Trigger._52000045_qd {
    public static class _main_02 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701}, jobCode: 100)) {
                    context.SetActor(triggerId: 5001, visible: false, initialSequence: "Idle_A");
                    context.SetActor(triggerId: 5002, visible: false, initialSequence: "Idle_A");
                    context.SetActor(triggerId: 5003, visible: false, initialSequence: "Idle_A");
                    return new StateReady_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_02 : TriggerState {
            internal StateReady_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000045, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{902}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUserPath(patrolName: "MS2PatrolData_2010");
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 902, patrolName: "MS2PatrolData_2004");
                context.MoveUserPath(patrolName: "MS2PatrolData_2003");
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateSetup_userscript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup_userscript01 : TriggerState {
            internal StateSetup_userscript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000045_QD__MAIN_02__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_A_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_A_03 : TriggerState {
            internal StateStart_A_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8010, 8013}, returnView: false);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000045_QD__MAIN_02__3$", arg4: 3);
                context.SetConversation(type: 1, spawnId: 902, script: "$52000045_QD__MAIN_02__4$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 902, script: "$52000045_QD__MAIN_02__1$", arg4: 3, arg5: 1);
                context.SetNpcEmotionLoop(spawnId: 902, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7003}, visible: true);
                context.CreateMonster(spawnIds: new []{887, 886, 888}, arg2: false);
                context.SetConversation(type: 1, spawnId: 902, script: "$52000045_QD__MAIN_02__5$", arg4: 1, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8014}, returnView: false);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000045_QD__MAIN_02__6$", arg4: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2200)) {
                    return new StateStart_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Down2_A", "Down_Idle_A", "Down_Idle_A", "Down_Idle_A", "Down_Idle_A", "Down_Idle_A"});
                context.SetEffect(triggerIds: new []{7005, 7004}, visible: true);
                context.CreateMonster(spawnIds: new []{872, 873}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2050)) {
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8014, 8015}, returnView: false);
                context.CreateMonster(spawnIds: new []{871, 876}, arg2: false);
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 80000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new StateStart_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{872, 875, 871, 876}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_09 : TriggerState {
            internal StateStart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7005}, visible: false);
                context.CreateMonster(spawnIds: new []{874, 873, 872}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_10 : TriggerState {
            internal StateStart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

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
                context.SetAchievement(triggerId: 701, type: "trigger", code: "InvestgatedScretroom");
                context.MoveUser(mapId: 52000046, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
