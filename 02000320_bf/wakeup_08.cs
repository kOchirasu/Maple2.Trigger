namespace Maple2.Trigger._02000320_bf {
    public static class _wakeup_08 {
        public class State자는중 : TriggerState {
            internal State자는중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 8001, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 8002, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 8003, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 8004, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 8005, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 8006, visible: true, initialSequence: "Stun_A");
            }

            public override TriggerState? Execute() {
                return new State도둑듬(context);
            }

            public override void OnExit() { }
        }

        private class State도둑듬 : TriggerState {
            internal State도둑듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000352}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000352}, arg2: 0)) {
                    return new State깨어남1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남1 : TriggerState {
            internal State깨어남1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 8);
                context.SetActor(triggerId: 8001, visible: true, initialSequence: "Bore_A");
                context.SetActor(triggerId: 8002, visible: true, initialSequence: "Bore_A");
                context.SetActor(triggerId: 8004, visible: false, initialSequence: "Bore_A");
                context.SetActor(triggerId: 8005, visible: false, initialSequence: "Stun_A");
                context.SetActor(triggerId: 8006, visible: false, initialSequence: "Stun_A");
                context.CreateMonster(spawnIds: new []{80004}, arg2: true);
                context.SetConversation(type: 1, spawnId: 80004, script: "$02000320_BF__WAKEUP_08__0$", arg4: 2, arg5: 0);
                context.CreateMonster(spawnIds: new []{80005}, arg2: true);
                context.SetConversation(type: 1, spawnId: 80005, script: "$02000320_BF__WAKEUP_08__1$", arg4: 2, arg5: 1);
                context.CreateMonster(spawnIds: new []{80006}, arg2: true);
                context.SetConversation(type: 1, spawnId: 80006, script: "$02000320_BF__WAKEUP_08__2$", arg4: 2, arg5: 2);
                context.CreateMonster(spawnIds: new []{80001});
                context.CreateMonster(spawnIds: new []{80002});
                context.CreateMonster(spawnIds: new []{80003});
                context.SetConversation(type: 1, spawnId: 80003, script: "$02000320_BF__WAKEUP_08__3$", arg4: 2, arg5: 3);
                context.SetConversation(type: 1, spawnId: 80001, script: "$02000320_BF__WAKEUP_08__4$", arg4: 2, arg5: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State깨어남2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남2 : TriggerState {
            internal State깨어남2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 4);
                context.SetConversation(type: 1, spawnId: 80002, script: "$02000320_BF__WAKEUP_08__5$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 80001, script: "$02000320_BF__WAKEUP_08__6$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 80003, script: "$02000320_BF__WAKEUP_08__7$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new State깨어남3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남3 : TriggerState {
            internal State깨어남3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 1);
                context.SetActor(triggerId: 8001, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 8002, visible: true, initialSequence: "Stun_A");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new State깨어남4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남4 : TriggerState {
            internal State깨어남4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{80004, 80005, 80006})) {
                    return new State다시잠듬(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{80004, 80005, 80006})) {
                    return new State다시자러감(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시자러감 : TriggerState {
            internal State다시자러감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnId: 80004);
                context.RemoveBalloonTalk(spawnId: 80005);
                context.RemoveBalloonTalk(spawnId: 80006);
                context.RemoveBalloonTalk(spawnId: 80001);
                context.RemoveBalloonTalk(spawnId: 80002);
                context.RemoveBalloonTalk(spawnId: 80003);
                context.SetTimer(timerId: "14", seconds: 4);
                context.SetConversation(type: 1, spawnId: 80004, script: "$02000320_BF__WAKEUP_08__8$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 80005, script: "$02000320_BF__WAKEUP_08__9$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 80006, script: "$02000320_BF__WAKEUP_08__10$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "14")) {
                    return new State다시잠듬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시잠듬 : TriggerState {
            internal State다시잠듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{80001, 80002, 80003, 80004, 80005, 80006});
                context.SetTimer(timerId: "15", seconds: 7);
                context.SetActor(triggerId: 8004, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 8005, visible: true, initialSequence: "Stun_A");
                context.SetActor(triggerId: 8006, visible: true, initialSequence: "Stun_A");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State도둑듬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
