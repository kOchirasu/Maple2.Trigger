namespace Maple2.Trigger._52010017_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 401, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 402, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 403, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 404, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 405, visible: false, animationEffect: false, animationDelay: 0);
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
                context.SetMesh(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3003}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3005}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3006}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3007}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3008}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{102}, questIds: new []{10002851}, questStates: new byte[]{1})) {
                    context.CreateMonster(spawnIds: new []{1002, 1003, 1004}, arg2: false);
                    context.CreateMonster(spawnIds: new []{2001}, arg2: true);
                    return new StateCameraCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic01 : TriggerState {
            internal StateCameraCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State미카Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script01 : TriggerState {
            internal State미카Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001});
                context.CreateMonster(spawnIds: new []{1005}, arg2: false);
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005");
                context.SetLadder(triggerId: 401, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 402, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 403, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 404, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 405, visible: true, animationEffect: true, animationDelay: 0);
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010017_QD__MAIN__0$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State체크포인트01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크포인트01 : TriggerState {
            internal State체크포인트01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 301, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    context.CreateMonster(spawnIds: new []{2002}, arg2: true);
                    return new StateCameraCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic02 : TriggerState {
            internal StateCameraCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 302, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미카Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script02 : TriggerState {
            internal State미카Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010017_QD__MAIN__1$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.CameraSelect(triggerId: 302, enable: false);
                    return new State체크포인트02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크포인트02 : TriggerState {
            internal State체크포인트02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002_A");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003_A");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004_A");
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005_A");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2002})) {
                    return new State미키이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미키이동01 : TriggerState {
            internal State미키이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005_A2");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 103, spawnIds: new []{1005})) {
                    return new State오브젝트01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트01 : TriggerState {
            internal State오브젝트01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(triggerIds: new []{3002}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCameraCinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic03 : TriggerState {
            internal StateCameraCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State타라Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타라Script01 : TriggerState {
            internal State타라Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001218, script: "$52010017_QD__MAIN__2$", arg4: 2);
                context.CameraSelect(triggerId: 303, enable: true);
                context.CreateMonster(spawnIds: new []{2003}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State체크포인트03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크포인트03 : TriggerState {
            internal State체크포인트03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 303, enable: false);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002_B");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003_B");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004_B");
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005_B");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2003})) {
                    return new State미키이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미키이동02 : TriggerState {
            internal State미키이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005_B2");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 104, spawnIds: new []{1005})) {
                    return new State오브젝트02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트02 : TriggerState {
            internal State오브젝트02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetMesh(triggerIds: new []{3003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(triggerIds: new []{3004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCameraCinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic04 : TriggerState {
            internal StateCameraCinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State둔바Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바Script01 : TriggerState {
            internal State둔바Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 304, enable: true);
                context.SetConversation(type: 2, spawnId: 11001217, script: "$52010017_QD__MAIN__3$", arg4: 2);
                context.CreateMonster(spawnIds: new []{2004}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State체크포인트04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크포인트04 : TriggerState {
            internal State체크포인트04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 304, enable: false);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002_C");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003_C");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004_C");
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005_C");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2004})) {
                    return new State미키이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미키이동03 : TriggerState {
            internal State미키이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005_C2");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 105, spawnIds: new []{1005})) {
                    return new State오브젝트03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트03 : TriggerState {
            internal State오브젝트03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetMesh(triggerIds: new []{3005}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(triggerIds: new []{3006}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCameraCinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic05 : TriggerState {
            internal StateCameraCinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State스타츠Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스타츠Script01 : TriggerState {
            internal State스타츠Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 305, enable: true);
                context.SetConversation(type: 2, spawnId: 11001292, script: "$52010017_QD__MAIN__4$", arg4: 2);
                context.CreateMonster(spawnIds: new []{2005}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State체크포인트05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State체크포인트05 : TriggerState {
            internal State체크포인트05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 305, enable: false);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002_D");
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003_D");
                context.MoveNpc(spawnId: 1004, patrolName: "MS2PatrolData_1004_D");
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005_D");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2005})) {
                    return new State미키이동04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미키이동04 : TriggerState {
            internal State미키이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005_D2");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 106, spawnIds: new []{1005})) {
                    return new State오브젝트04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트04 : TriggerState {
            internal State오브젝트04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetMesh(triggerIds: new []{3007}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(triggerIds: new []{3008}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCameraCinematic06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic06 : TriggerState {
            internal StateCameraCinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1005, patrolName: "MS2PatrolData_1005_D3");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State미카Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script03 : TriggerState {
            internal State미카Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010017_QD__MAIN__5$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미카Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script04 : TriggerState {
            internal State미카Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010017_QD__MAIN__6$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State이동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동Wait : TriggerState {
            internal State이동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 110, type: "trigger", code: "Getalllamestone");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.MoveUser(mapId: 02010034, portalId: 3, boxId: 110);
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
