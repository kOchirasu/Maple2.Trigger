namespace Maple2.Trigger._52010038_qd {
    public static class _event {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
                context.SetAgent(arg1: "8009", arg2: true);
                context.SetAgent(arg1: "8010", arg2: true);
                context.SetAgent(arg1: "8011", arg2: true);
                context.SetAgent(arg1: "8012", arg2: true);
                context.SetAgent(arg1: "8013", arg2: true);
                context.SetSkill(arg1: new[] {710}, arg2: false);
                context.SetSkill(arg1: new[] {711}, arg2: false);
                context.SetEffect(arg1: new[] {6110}, arg2: false);
                context.SetEffect(arg1: new[] {6111}, arg2: false);
                context.SetEffect(arg1: new[] {6298}, arg2: false);
                context.SetActor(arg1: 220, arg2: false);
                context.SetActor(arg1: 221, arg2: false);
                context.SetActor(arg1: 222, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "EventStart") == 1) {
                    context.State = new State이벤트조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이벤트조건 : TriggerState {
            internal State이벤트조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6298}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    context.State = new State이벤트시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이벤트시작 : TriggerState {
            internal State이벤트시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1200}, arg2: false);
                context.DestroyMonster(arg1: new[] {1201});
                context.SetConversation(arg1: 1, arg2: 1200, arg3: "$52010038_QD__EVENT__0$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 1200, arg2: "MS2PatrolData_1200");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 104, arg2: new[] {1200})) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {710}, arg2: true);
                context.SetEffect(arg1: new[] {6110}, arg2: true);
                context.CreateMonster(arg1: new[] {2012, 2013, 2014, 2015}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State감지대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State감지대기 : TriggerState {
            internal State감지대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.SetAgent(arg1: "8011", arg2: false);
                context.SetAgent(arg1: "8012", arg2: false);
                context.SetAgent(arg1: "8013", arg2: false);
                context.SetConversation(arg1: 1, arg2: 1200, arg3: "$52010038_QD__EVENT__2$", arg4: 3, arg5: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    context.State = new State폭발시퀀스시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발시퀀스시작 : TriggerState {
            internal State폭발시퀀스시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 220, arg2: true, arg3: "Regen_A");
                context.SetActor(arg1: 221, arg2: true, arg3: "Regen_A");
                context.SetActor(arg1: 222, arg2: true, arg3: "Regen_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State폭발딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발딜레이 : TriggerState {
            internal State폭발딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 220, arg2: true, arg3: "Attack_01_A");
                context.SetActor(arg1: 221, arg2: true, arg3: "Attack_01_A");
                context.SetActor(arg1: 222, arg2: true, arg3: "Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State폭발(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭발 : TriggerState {
            internal State폭발(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 220, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 221, arg2: true, arg3: "Attack_02_A");
                context.SetActor(arg1: 222, arg2: true, arg3: "Attack_02_A");
                context.SetSkill(arg1: new[] {711}, arg2: true);
                context.SetEffect(arg1: new[] {6298}, arg2: false);
                context.SetEffect(arg1: new[] {6111}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new State폭탄숨김(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭탄숨김 : TriggerState {
            internal State폭탄숨김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 220, arg2: false);
                context.SetActor(arg1: 221, arg2: false);
                context.SetActor(arg1: 222, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1300)) {
                    context.State = new State점수(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State점수 : TriggerState {
            internal State점수(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {4010}, arg2: false);
                context.CreateMonster(arg1: new[] {4030}, arg2: false);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000,
                    script: "$52010038_QD__event__4$", voice: @"ko/Npc/00002105");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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