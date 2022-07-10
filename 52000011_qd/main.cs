namespace Maple2.Trigger._52000011_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7101, 7102, 7103, 7104, 7105, 7106, 7107, 7108, 7109, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7117, 7118, 7119, 7120, 7121, 7122, 7123, 7124, 7125, 7126, 7127, 7128, 7129, 7130, 7131, 7132, 7133, 7134, 7135, 7136, 7137, 7138, 7139, 7140, 7141, 7142, 7143, 7144, 7145, 7146, 7147, 7148, 7149, 7150, 7151, 7152, 7153, 7154, 7155, 7156, 7157, 7158, 7159, 7160, 7161, 7162, 7163, 7164, 7165, 7166, 7167, 7168, 7169, 7170, 7201, 7202, 7203, 7204, 7205, 7206, 7207, 7208, 7209, 7210, 7211, 7212, 7213, 7214, 7215, 7216, 7217, 7218, 7219, 7220, 7221, 7222, 7223, 7224, 7225, 7226, 7227, 7228, 7229, 7230, 7231, 7232, 7233, 7234, 7235, 7236, 7237, 7238, 7239, 7240, 7241, 7242, 7243, 7244, 7245, 7246, 7247, 7248, 7249, 7250, 7251, 7252, 7253, 7254, 7255, 7256, 7257, 7258, 7259, 7260, 7261, 7262, 7263, 7264, 7265, 7266, 7267, 7268, 7269, 7270}, enabled: true);
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
                context.SetActor(triggerId: 201, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 202, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 204, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 205, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 206, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 208, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetAgent(triggerIds: new []{9001, 9002, 9003, 9004, 9005, 9006}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{101}, questIds: new []{10002594}, questStates: new byte[]{1})) {
                    return new StateStartCinematicDelay(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematicDelay : TriggerState {
            internal StateStartCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 301, enable: true);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State오스칼01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼01 : TriggerState {
            internal State오스칼01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{302}, returnView: true);
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11000015, script: "$52000011_QD__MAIN__0$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State오스칼02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼02 : TriggerState {
            internal State오스칼02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11000015, script: "$52000011_QD__MAIN__1$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 301, enable: false);
            }

            public override TriggerState? Execute() {
                return new StateNPC교체(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC교체 : TriggerState {
            internal StateNPC교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2002}, arg2: false);
                context.DestroyMonster(spawnIds: new []{2001});
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{2002})) {
                    return new StateMobCreation01(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation01 : TriggerState {
            internal StateMobCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 202, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1001})) {
                    return new StateMobCreation02(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation02 : TriggerState {
            internal StateMobCreation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new State문열림02(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림02 : TriggerState {
            internal State문열림02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{9001, 9002}, visible: false);
                context.SetBreakable(triggerIds: new []{7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041}, enabled: false);
                context.SetActor(triggerId: 203, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 103, spawnIds: new []{2002})) {
                    return new StateMobCreation03(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation03 : TriggerState {
            internal StateMobCreation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 204, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{1003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1003})) {
                    return new StateMobCreation04(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation04 : TriggerState {
            internal StateMobCreation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1004})) {
                    return new State문열림03(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림03 : TriggerState {
            internal State문열림03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{9003, 9004}, visible: false);
                context.SetBreakable(triggerIds: new []{7101, 7102, 7103, 7104, 7105, 7106, 7107, 7108, 7109, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7117, 7118, 7119, 7120, 7121, 7122, 7123, 7124, 7125, 7126, 7127, 7128, 7129, 7130, 7131, 7132, 7133, 7134, 7135, 7136, 7137, 7138, 7139, 7140, 7141, 7142, 7143, 7144, 7145, 7146, 7147, 7148, 7149, 7150, 7151, 7152, 7153, 7154, 7155, 7156, 7157, 7158, 7159, 7160, 7161, 7162, 7163, 7164, 7165, 7166, 7167, 7168, 7169, 7170}, enabled: false);
                context.SetActor(triggerId: 205, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_2003");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 104, spawnIds: new []{2002})) {
                    return new StateMobCreation05(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation05 : TriggerState {
            internal StateMobCreation05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 206, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{1005}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1005})) {
                    return new StateMobCreation06(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation06 : TriggerState {
            internal StateMobCreation06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1006})) {
                    return new State문열림04(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림04 : TriggerState {
            internal State문열림04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{9005, 9006}, visible: false);
                context.SetBreakable(triggerIds: new []{7201, 7202, 7203, 7204, 7205, 7206, 7207, 7208, 7209, 7210, 7211, 7212, 7213, 7214, 7215, 7216, 7217, 7218, 7219, 7220, 7221, 7222, 7223, 7224, 7225, 7226, 7227, 7228, 7229, 7230, 7231, 7232, 7233, 7234, 7235, 7236, 7237, 7238, 7239, 7240, 7241, 7242, 7243, 7244, 7245, 7246, 7247, 7248, 7249, 7250, 7251, 7252, 7253, 7254, 7255, 7256, 7257, 7258, 7259, 7260, 7261, 7262, 7263, 7264, 7265, 7266, 7267, 7268, 7269, 7270}, enabled: false);
                context.SetActor(triggerId: 207, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 2002, patrolName: "MS2PatrolData_2004");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 105, spawnIds: new []{2002})) {
                    return new State문열림05(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림05 : TriggerState {
            internal State문열림05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 208, visible: true, initialSequence: "Opened");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 106, spawnIds: new []{2002})) {
                    return new StateNPC교체2(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체2 : TriggerState {
            internal StateNPC교체2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2003}, arg2: false);
                context.DestroyMonster(spawnIds: new []{2002});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{10002595}, questStates: new byte[]{2})) {
                    return new StatePortalCreation(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 30);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    context.MoveUser(mapId: 02000309, portalId: 2, boxId: 199);
                    return new StateEnd(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 2001, 2002, 2003});
            }

            public override TriggerState? Execute() {
                return new StateStart(context);
            }

            public override void OnExit() { }
        }
    }
}
