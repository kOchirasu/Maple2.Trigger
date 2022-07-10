namespace Maple2.Trigger._52000048_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210}, arg2: false);
                context.CreateMonster(spawnIds: new []{2001});
                context.SetMesh(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{600, 601}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enable: true);
                context.MoveNpc(spawnId: 1101, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1102, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1103, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1104, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1105, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1106, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1107, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1108, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1109, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1110, patrolName: "MS2PatrolData_A");
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_B");
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_B");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_B");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_B");
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_B");
                context.MoveNpc(spawnId: 1006, patrolName: "MS2PatrolData_B");
                context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_B");
                context.MoveNpc(spawnId: 1008, patrolName: "MS2PatrolData_B");
                context.MoveNpc(spawnId: 1009, patrolName: "MS2PatrolData_B");
                context.MoveNpc(spawnId: 1010, patrolName: "MS2PatrolData_B");
                context.MoveNpc(spawnId: 1201, patrolName: "MS2PatrolData_C");
                context.MoveNpc(spawnId: 1202, patrolName: "MS2PatrolData_C");
                context.MoveNpc(spawnId: 1203, patrolName: "MS2PatrolData_C");
                context.MoveNpc(spawnId: 1204, patrolName: "MS2PatrolData_C");
                context.MoveNpc(spawnId: 1205, patrolName: "MS2PatrolData_C");
                context.MoveNpc(spawnId: 1206, patrolName: "MS2PatrolData_C");
                context.MoveNpc(spawnId: 1207, patrolName: "MS2PatrolData_C");
                context.MoveNpc(spawnId: 1208, patrolName: "MS2PatrolData_C");
                context.MoveNpc(spawnId: 1209, patrolName: "MS2PatrolData_C");
                context.MoveNpc(spawnId: 1210, patrolName: "MS2PatrolData_C");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동 : TriggerState {
            internal StateCamera이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 302, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State칸두라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라이동 : TriggerState {
            internal State칸두라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_K1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.SetNpcEmotionSequence(spawnId: 2001, sequenceName: "Attack_01_A");
                    return new State칸두라이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라이동2 : TriggerState {
            internal State칸두라이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_K2");
                    return new StateCamera이동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동Wait : TriggerState {
            internal StateCamera이동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateCamera이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동2 : TriggerState {
            internal StateCamera이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 303, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State라오즈Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라오즈Spawn : TriggerState {
            internal State라오즈Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.CreateMonster(spawnIds: new []{2002});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePC말풍선(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선 : TriggerState {
            internal StatePC말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_PC");
                context.SetConversation(type: 1, spawnId: 0, script: "$52000048_QD__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State라오즈Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라오즈Script01 : TriggerState {
            internal State라오즈Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001768, script: "$52000048_QD__MAIN__1$", arg4: 3);
                context.SetSkip(state: new State라오즈Script01스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State라오즈Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라오즈Script01스킵 : TriggerState {
            internal State라오즈Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State라오즈Script02(context);
            }

            public override void OnExit() { }
        }

        private class State라오즈Script02 : TriggerState {
            internal State라오즈Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001768, script: "$52000048_QD__MAIN__2$", arg4: 6);
                context.SetSkip(state: new State라오즈Script02스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State라오즈Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라오즈Script02스킵 : TriggerState {
            internal State라오즈Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State라오즈Script03(context);
            }

            public override void OnExit() { }
        }

        private class State라오즈Script03 : TriggerState {
            internal State라오즈Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 304, enable: true);
                context.SetConversation(type: 2, spawnId: 11001768, script: "$52000048_QD__MAIN__3$", arg4: 6);
                context.SetSkip(state: new State라오즈Script03스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuest완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라오즈Script03스킵 : TriggerState {
            internal State라오즈Script03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateQuest완료(context);
            }

            public override void OnExit() { }
        }

        private class StateQuest완료 : TriggerState {
            internal StateQuest완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 101, type: "trigger", code: "MessageThroughAnimar");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 304, enable: false);
                context.MoveUser(mapId: 52000050, portalId: 1);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
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

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
