namespace Maple2.Trigger._80000010_bonus {
    public static class _meso {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{201});
                context.CreateItem(spawnIds: new []{202});
                context.CreateItem(spawnIds: new []{203});
                context.CreateItem(spawnIds: new []{204});
                context.CreateItem(spawnIds: new []{205});
                context.CreateItem(spawnIds: new []{206});
                context.CreateItem(spawnIds: new []{207});
                context.CreateItem(spawnIds: new []{208});
                context.CreateItem(spawnIds: new []{209});
                context.CreateItem(spawnIds: new []{210});
                context.CreateItem(spawnIds: new []{211});
                context.CreateItem(spawnIds: new []{212});
                context.CreateItem(spawnIds: new []{213});
                context.CreateItem(spawnIds: new []{214});
                context.CreateItem(spawnIds: new []{215});
                context.CreateItem(spawnIds: new []{216});
                context.CreateItem(spawnIds: new []{217});
                context.CreateItem(spawnIds: new []{218});
                context.CreateItem(spawnIds: new []{219});
                context.CreateItem(spawnIds: new []{220});
                context.CreateItem(spawnIds: new []{221});
                context.CreateItem(spawnIds: new []{222});
                context.CreateItem(spawnIds: new []{223});
                context.CreateItem(spawnIds: new []{224});
                context.CreateItem(spawnIds: new []{225});
                context.CreateItem(spawnIds: new []{226});
                context.CreateItem(spawnIds: new []{227});
                context.CreateItem(spawnIds: new []{228});
                context.CreateItem(spawnIds: new []{229});
                context.CreateItem(spawnIds: new []{230});
                context.CreateItem(spawnIds: new []{231});
                context.CreateItem(spawnIds: new []{232});
                context.CreateItem(spawnIds: new []{233});
                context.CreateItem(spawnIds: new []{234});
                context.CreateItem(spawnIds: new []{235});
                context.CreateItem(spawnIds: new []{236});
                context.CreateItem(spawnIds: new []{237});
                context.CreateItem(spawnIds: new []{238});
                context.CreateItem(spawnIds: new []{239});
                context.CreateItem(spawnIds: new []{240});
                context.CreateItem(spawnIds: new []{241});
                context.CreateItem(spawnIds: new []{242});
                context.CreateItem(spawnIds: new []{243});
                context.CreateItem(spawnIds: new []{244});
                context.CreateItem(spawnIds: new []{245});
                context.CreateItem(spawnIds: new []{246});
                context.CreateItem(spawnIds: new []{247});
                context.CreateItem(spawnIds: new []{248});
                context.CreateItem(spawnIds: new []{249});
                context.CreateItem(spawnIds: new []{250});
                context.CreateItem(spawnIds: new []{251});
                context.CreateItem(spawnIds: new []{252});
                context.CreateItem(spawnIds: new []{253});
                context.CreateItem(spawnIds: new []{254});
                context.CreateItem(spawnIds: new []{255});
                context.CreateItem(spawnIds: new []{256});
                context.CreateItem(spawnIds: new []{257});
                context.CreateItem(spawnIds: new []{258});
                context.CreateItem(spawnIds: new []{259});
                context.CreateItem(spawnIds: new []{260});
                context.CreateItem(spawnIds: new []{261});
                context.CreateItem(spawnIds: new []{262});
                context.CreateItem(spawnIds: new []{263});
                context.CreateItem(spawnIds: new []{264});
                context.CreateItem(spawnIds: new []{265});
                context.CreateItem(spawnIds: new []{266});
                context.CreateItem(spawnIds: new []{267});
                context.CreateItem(spawnIds: new []{268});
                context.CreateItem(spawnIds: new []{269});
                context.CreateItem(spawnIds: new []{270});
                context.CreateItem(spawnIds: new []{9001, 9002, 9003, 9004, 9005});
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State완료2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료2 : TriggerState {
            internal State완료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
