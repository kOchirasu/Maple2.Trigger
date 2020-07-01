namespace Maple2.Trigger._52000011_qd {
    public static class _main {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7101, 7102, 7103, 7104, 7105, 7106, 7107, 7108, 7109, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7117, 7118, 7119, 7120, 7121, 7122, 7123, 7124, 7125, 7126, 7127, 7128, 7129, 7130, 7131, 7132, 7133, 7134, 7135, 7136, 7137, 7138, 7139, 7140, 7141, 7142, 7143, 7144, 7145, 7146, 7147, 7148, 7149, 7150, 7151, 7152, 7153, 7154, 7155, 7156, 7157, 7158, 7159, 7160, 7161, 7162, 7163, 7164, 7165, 7166, 7167, 7168, 7169, 7170, 7201, 7202, 7203, 7204, 7205, 7206, 7207, 7208, 7209, 7210, 7211, 7212, 7213, 7214, 7215, 7216, 7217, 7218, 7219, 7220, 7221, 7222, 7223, 7224, 7225, 7226, 7227, 7228, 7229, 7230, 7231, 7232, 7233, 7234, 7235, 7236, 7237, 7238, 7239, 7240, 7241, 7242, 7243, 7244, 7245, 7246, 7247, 7248, 7249, 7250, 7251, 7252, 7253, 7254, 7255, 7256, 7257, 7258, 7259, 7260, 7261, 7262, 7263, 7264, 7265, 7266, 7267, 7268, 7269, 7270}, arg2: true);
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
                context.SetActor(arg1: 201, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 202, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 203, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 204, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 205, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 206, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 207, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 208, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {10002594}, arg3: new byte[] {1})) {
                    return new State연출시작딜레이(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출시작딜레이 : TriggerState {
            internal State연출시작딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State연출시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State오스칼01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼01 : TriggerState {
            internal State오스칼01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {302}, arg2: true);
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$52000011_QD__MAIN__0$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State오스칼02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼02 : TriggerState {
            internal State오스칼02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$52000011_QD__MAIN__1$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateNPC교체(context);
            }

            public override void OnExit() { }
        }

        private class StateNPC교체 : TriggerState {
            internal StateNPC교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
                context.DestroyMonster(arg1: new[] {2001});
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {2002})) {
                    return new State몬스터생성01(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터생성01 : TriggerState {
            internal State몬스터생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 202, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1001})) {
                    return new State몬스터생성02(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터생성02 : TriggerState {
            internal State몬스터생성02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1002})) {
                    return new State문열림02(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림02 : TriggerState {
            internal State문열림02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9001, 9002}, arg2: false);
                context.SetBreakable(arg1: new[] {7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041}, arg2: false);
                context.SetActor(arg1: 203, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {2002})) {
                    return new State몬스터생성03(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터생성03 : TriggerState {
            internal State몬스터생성03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 204, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1003})) {
                    return new State몬스터생성04(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터생성04 : TriggerState {
            internal State몬스터생성04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1004})) {
                    return new State문열림03(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림03 : TriggerState {
            internal State문열림03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9003, 9004}, arg2: false);
                context.SetBreakable(arg1: new[] {7101, 7102, 7103, 7104, 7105, 7106, 7107, 7108, 7109, 7110, 7111, 7112, 7113, 7114, 7115, 7116, 7117, 7118, 7119, 7120, 7121, 7122, 7123, 7124, 7125, 7126, 7127, 7128, 7129, 7130, 7131, 7132, 7133, 7134, 7135, 7136, 7137, 7138, 7139, 7140, 7141, 7142, 7143, 7144, 7145, 7146, 7147, 7148, 7149, 7150, 7151, 7152, 7153, 7154, 7155, 7156, 7157, 7158, 7159, 7160, 7161, 7162, 7163, 7164, 7165, 7166, 7167, 7168, 7169, 7170}, arg2: false);
                context.SetActor(arg1: 205, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2003");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 104, arg2: new[] {2002})) {
                    return new State몬스터생성05(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터생성05 : TriggerState {
            internal State몬스터생성05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 206, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new State몬스터생성06(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터생성06 : TriggerState {
            internal State몬스터생성06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1006})) {
                    return new State문열림04(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림04 : TriggerState {
            internal State문열림04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9005, 9006}, arg2: false);
                context.SetBreakable(arg1: new[] {7201, 7202, 7203, 7204, 7205, 7206, 7207, 7208, 7209, 7210, 7211, 7212, 7213, 7214, 7215, 7216, 7217, 7218, 7219, 7220, 7221, 7222, 7223, 7224, 7225, 7226, 7227, 7228, 7229, 7230, 7231, 7232, 7233, 7234, 7235, 7236, 7237, 7238, 7239, 7240, 7241, 7242, 7243, 7244, 7245, 7246, 7247, 7248, 7249, 7250, 7251, 7252, 7253, 7254, 7255, 7256, 7257, 7258, 7259, 7260, 7261, 7262, 7263, 7264, 7265, 7266, 7267, 7268, 7269, 7270}, arg2: false);
                context.SetActor(arg1: 207, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_2004");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 105, arg2: new[] {2002})) {
                    return new State문열림05(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림05 : TriggerState {
            internal State문열림05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 208, arg2: true, arg3: "Opened");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 106, arg2: new[] {2002})) {
                    return new StateNPC교체2(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체2 : TriggerState {
            internal StateNPC교체2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2003}, arg2: false);
                context.DestroyMonster(arg1: new[] {2002});
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {10002595}, arg3: new byte[] {2})) {
                    return new State포털생성(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.MoveUser(arg1: 02000309, arg2: 2, arg3: 199);
                    return new State종료(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 2001, 2002, 2003});
            }

            public override TriggerState Execute() {
                return new State시작(context);
            }

            public override void OnExit() { }
        }
    }
}