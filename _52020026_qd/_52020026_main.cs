namespace Maple2.Trigger._52020026_qd {
    public static class _52020026_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false);
                context.SetMesh(
                    arg1: new[] {
                        1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016,
                        1017, 1018
                    }, arg2: false);
                context.SetAgent(arg1: "9001", arg2: true);
                context.SetAgent(arg1: "9002", arg2: true);
                context.SetAgent(arg1: "9003", arg2: true);
                context.SetAgent(arg1: "9004", arg2: true);
                context.SetAgent(arg1: "9005", arg2: true);
                context.SetAgent(arg1: "9006", arg2: true);
                context.SetAgent(arg1: "9007", arg2: true);
                context.SetAgent(arg1: "9008", arg2: true);
                context.SetAgent(arg1: "9009", arg2: true);
                context.SetAgent(arg1: "9010", arg2: true);
                context.SetAgent(arg1: "9011", arg2: true);
                context.SetAgent(arg1: "9012", arg2: true);
                context.SetAgent(arg1: "9013", arg2: true);
                context.SetAgent(arg1: "9014", arg2: true);
                context.SetAgent(arg1: "9015", arg2: true);
                context.SetAgent(arg1: "9016", arg2: true);
                context.SetAgent(arg1: "9017", arg2: true);
                context.SetAgent(arg1: "9018", arg2: true);
                context.SetAgent(arg1: "9019", arg2: true);
                context.SetAgent(arg1: "9020", arg2: true);
                context.SetAgent(arg1: "9021", arg2: true);
                context.SetAgent(arg1: "9022", arg2: true);
                context.SetAgent(arg1: "9023", arg2: true);
                context.SetAgent(arg1: "9024", arg2: true);
                context.SetAgent(arg1: "9025", arg2: true);
                context.SetAgent(arg1: "9026", arg2: true);
                context.SetAgent(arg1: "9027", arg2: true);
                context.SetAgent(arg1: "9028", arg2: true);
                context.SetAgent(arg1: "9029", arg2: true);
                context.SetAgent(arg1: "9030", arg2: true);
                context.SetAgent(arg1: "9031", arg2: true);
                context.SetAgent(arg1: "9032", arg2: true);
                context.SetInteractObject(arg1: new[] {10001320}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001321}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001322}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001323}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001324}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001325}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State1층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1층 : TriggerState {
            internal State1층(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State1층레버활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1층레버활성 : TriggerState {
            internal State1층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "레버를 작동시켜 계단을 완성하세요.", arg3: 5000);
                context.SetInteractObject(arg1: new[] {10001320}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001320}, arg2: 0)) {
                    context.State = new State2층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2층 : TriggerState {
            internal State2층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetMesh(arg1: new[] {1001, 1002, 1003}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {102})) {
                    context.State = new State2층레버활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2층레버활성 : TriggerState {
            internal State2층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001321}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001321}, arg2: 0)) {
                    context.State = new State3층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3층 : TriggerState {
            internal State3층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.SetMesh(arg1: new[] {1004, 1005, 1006}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {103, 104})) {
                    context.State = new State3층레버활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3층레버활성 : TriggerState {
            internal State3층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001322}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001322}, arg2: 0)) {
                    context.State = new State4층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4층 : TriggerState {
            internal State4층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.CreateMonster(arg1: new[] {106}, arg2: false);
                context.SetMesh(arg1: new[] {1007, 1008, 1009}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {105, 106})) {
                    context.State = new State4층레버활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4층레버활성 : TriggerState {
            internal State4층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001323}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001323}, arg2: 0)) {
                    context.State = new State5층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5층 : TriggerState {
            internal State5층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {107}, arg2: false);
                context.SetMesh(arg1: new[] {1010, 1011, 1012}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {906})) {
                    context.State = new State5층_벽부수기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5층_벽부수기 : TriggerState {
            internal State5층_벽부수기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9001", arg2: false);
                context.SetAgent(arg1: "9002", arg2: false);
                context.SetAgent(arg1: "9003", arg2: false);
                context.SetAgent(arg1: "9004", arg2: false);
                context.SetAgent(arg1: "9005", arg2: false);
                context.SetAgent(arg1: "9006", arg2: false);
                context.SetAgent(arg1: "9007", arg2: false);
                context.SetAgent(arg1: "9008", arg2: false);
                context.SetAgent(arg1: "9009", arg2: false);
                context.SetAgent(arg1: "9010", arg2: false);
                context.SetAgent(arg1: "9011", arg2: false);
                context.SetAgent(arg1: "9012", arg2: false);
                context.SetAgent(arg1: "9013", arg2: false);
                context.SetAgent(arg1: "9014", arg2: false);
                context.SetAgent(arg1: "9015", arg2: false);
                context.SetAgent(arg1: "9016", arg2: false);
                context.CreateMonster(arg1: new[] {108}, arg2: true);
                context.SetSkill(arg1: new[] {1}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {107, 108})) {
                    context.State = new State5층레버활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5층레버활성 : TriggerState {
            internal State5층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001324}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001324}, arg2: 0)) {
                    context.State = new State6층(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6층 : TriggerState {
            internal State6층(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {109}, arg2: false);
                context.CreateMonster(arg1: new[] {110}, arg2: false);
                context.SetMesh(arg1: new[] {1013, 1014, 1015}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {907})) {
                    context.State = new State6층_벽부수기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6층_벽부수기 : TriggerState {
            internal State6층_벽부수기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9017", arg2: false);
                context.SetAgent(arg1: "9018", arg2: false);
                context.SetAgent(arg1: "9019", arg2: false);
                context.SetAgent(arg1: "9020", arg2: false);
                context.SetAgent(arg1: "9021", arg2: false);
                context.SetAgent(arg1: "9022", arg2: false);
                context.SetAgent(arg1: "9023", arg2: false);
                context.SetAgent(arg1: "9024", arg2: false);
                context.SetAgent(arg1: "9025", arg2: false);
                context.SetAgent(arg1: "9026", arg2: false);
                context.SetAgent(arg1: "9027", arg2: false);
                context.SetAgent(arg1: "9028", arg2: false);
                context.SetAgent(arg1: "9029", arg2: false);
                context.SetAgent(arg1: "9030", arg2: false);
                context.SetAgent(arg1: "9031", arg2: false);
                context.SetAgent(arg1: "9032", arg2: false);
                context.CreateMonster(arg1: new[] {111}, arg2: true);
                context.SetSkill(arg1: new[] {2}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {109, 110, 111})) {
                    context.State = new State6층레버활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6층레버활성 : TriggerState {
            internal State6층레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001325}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001325}, arg2: 0)) {
                    context.State = new State포탈활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈활성화 : TriggerState {
            internal State포탈활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1016, 1017, 1018}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}