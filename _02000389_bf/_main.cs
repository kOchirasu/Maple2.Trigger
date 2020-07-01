namespace Maple2.Trigger._02000389_bf {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 11001, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 11002, isEnable: false);
                context.CreateMonster(arg1: new[] {101, 102}, arg2: true);
                context.SetMesh(arg1: new[] {1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816, 1817, 1818, 1819, 1820, 1821, 1822, 1823, 1824, 1825, 1826, 1827, 1828, 1829, 1830, 1831, 1832, 1833, 1834, 1835, 1836, 1837, 1838, 1839, 1840, 1841, 1842, 1843, 1844, 1845, 1846, 1847, 1848, 1849, 1850, 1851, 1852, 1853, 1854, 1855, 1856, 1857, 1858, 1859, 1860, 1861, 1862, 1863, 1864, 1865, 1866, 1867, 1868, 1869, 1870, 1871, 1872, 1873, 1874, 1875, 1876, 1877, 1878, 1879, 1880, 1881, 1882, 1883, 1884, 1885, 1886, 1887, 1888, 1889, 1890, 1891, 1892, 1893, 1894, 1895, 1896, 1897, 1898, 1899, 1900, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 1917, 1918, 1919, 1920, 1921, 1922, 1923, 1924, 1925, 1926, 1927, 1928, 1929, 1930, 1931, 1932, 1933, 1934, 1935, 1936, 1937, 1938, 1939, 1940, 1941, 1942, 1943, 1944, 1945, 1946, 1947, 1948, 1949, 1950, 1951, 1952, 1953, 1954, 1955, 1956, 1957, 1958, 1959, 1960, 1961, 1962, 1963, 1964, 1965, 1966, 1967, 1968, 1969, 1970, 1971, 1972, 1973, 1974, 1975, 1976, 1977, 1978, 1979, 1980, 1981, 1982, 1983, 1984, 1985, 1986, 1987, 1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {7001, 7002, 7003, 7004, 7005, 7011, 7012, 7013}, arg2: false);
                context.SetMesh(arg1: new[] {3007, 3008, 3009}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 3001, arg2: true, arg3: "Run_A");
                context.SetActor(arg1: 3002, arg2: true, arg3: "Run_A");
                context.SetActor(arg1: 3003, arg2: true, arg3: "Run_A");
                context.SetActor(arg1: 3004, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 3005, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 3006, arg2: true, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 3101, arg2: false, arg3: "Run_A");
                context.SetActor(arg1: 3102, arg2: false, arg3: "Run_A");
                context.SetActor(arg1: 3103, arg2: false, arg3: "Run_A");
                context.SetActor(arg1: 3104, arg2: false, arg3: "Run_A");
                context.SetBreakable(arg1: new[] {1801, 1802, 1803, 1804, 1805, 1806, 1807}, arg2: false);
                context.SetLocalCamera(cameraId: 8100, enable: false);
                context.SetLocalCamera(cameraId: 8101, enable: false);
                context.SetMesh(arg1: new[] {1001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1990, 1991, 1992, 1993}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new Stateready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "start_ready");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Walk_A", arg3: 9999999999999999f);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Walk_A", arg3: 9999999999999999f);
                context.CameraSelectPath(arg1: new[] {8001, 8002, 8003}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Stateready_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateready_02 : TriggerState {
            internal Stateready_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000389_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000389_BF__MAIN__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statestart_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart_ready : TriggerState {
            internal Statestart_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new Statestart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new Statescene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8100, enable: true);
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000389_BF__MAIN__2$", arg4: 2, arg5: 5);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000389_BF__MAIN__3$", arg4: 2, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$02000389_BF__MAIN__4$", arg4: 2, arg5: 6);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204, 205})) {
                    return new Statescene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {206, 207, 208, 209}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02000389_BF__MAIN__5$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {206, 207, 208, 209})) {
                    return new Statescene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {210, 211, 212, 213, 214}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {210, 211, 212, 213, 214})) {
                    return new Statescene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_04_ready : TriggerState {
            internal Statescene_04_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statescene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "scene_07_ready");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8004, 8005, 8006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000389_BF__MAIN__6$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000389_BF__MAIN__7$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2003");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Statescene_07_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_07_ready : TriggerState {
            internal Statescene_07_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new Statescene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetActor(arg1: 3001, arg2: false, arg3: "Run_A");
                context.SetActor(arg1: 3002, arg2: false, arg3: "Run_A");
                context.SetActor(arg1: 3003, arg2: false, arg3: "Run_A");
                context.SetActor(arg1: 3004, arg2: false, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 3005, arg2: false, arg3: "Attack_Idle_A");
                context.SetActor(arg1: 3006, arg2: false, arg3: "Attack_Idle_A");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetLocalCamera(cameraId: 8100, enable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statescene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_08 : TriggerState {
            internal Statescene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {214, 206, 207, 208, 201, 202, 203}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new Stateboss_leftTurn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn : TriggerState {
            internal Stateboss_leftTurn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {302}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG\Common\Sound\Eff_Object_WaterJump_Splash_01.xml");
                context.SetConversation(arg1: 1, arg2: 302, arg3: "$02000389_BF__MAIN__8$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 302, arg3: "$02000389_BF__MAIN__9$", arg4: 2, arg5: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Stateboss_leftTurn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn_01 : TriggerState {
            internal Stateboss_leftTurn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 302, arg2: "Attack_01_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new Stateboss_leftTurn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn_02 : TriggerState {
            internal Stateboss_leftTurn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7002}, arg2: true);
                context.SetSkill(arg1: new[] {30002, 30010, 30011}, arg2: true);
                context.EnableSpawnPointPc(spawnPointId: 11002, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 11001, isEnable: false);
                context.SetUserValue(triggerId: 10000002, key: "Error", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Stateboss_leftTurn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn_03 : TriggerState {
            internal Stateboss_leftTurn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {215, 216, 217, 218}, arg2: false);
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_2004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Stateboss_leftTurn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn_04 : TriggerState {
            internal Stateboss_leftTurn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {302});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new Stateboss_rightTurn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_rightTurn : TriggerState {
            internal Stateboss_rightTurn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: true, path: @"BG\Common\Sound\Eff_Object_WaterJump_Splash_01.xml");
                context.CreateMonster(arg1: new[] {301}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2003");
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$02000389_BF__MAIN__10$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Stateboss_rightTurn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_rightTurn_01 : TriggerState {
            internal Stateboss_rightTurn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Attack_01_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new Stateboss_rightTurn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_rightTurn_02 : TriggerState {
            internal Stateboss_rightTurn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetSkill(arg1: new[] {30001, 30010, 30011}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Stateboss_rightTurn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_rightTurn_03 : TriggerState {
            internal Stateboss_rightTurn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {219, 220, 222, 223}, arg2: false);
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_2004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Stateboss_rightTurn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_rightTurn_04 : TriggerState {
            internal Stateboss_rightTurn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {301});
                context.SetMesh(arg1: new[] {1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815, 1816, 1817, 1818, 1819, 1820, 1821, 1822, 1823, 1824, 1825, 1826, 1827, 1828, 1829, 1830, 1831, 1832, 1833, 1834, 1835, 1836, 1837, 1838, 1839, 1840, 1841, 1842, 1843, 1844, 1845, 1846, 1847, 1848, 1849, 1850, 1851, 1852, 1853, 1854, 1855, 1856, 1857, 1858, 1859, 1860, 1861, 1862, 1863, 1864, 1865, 1866, 1867, 1868, 1869, 1870, 1871, 1872, 1873, 1874, 1875, 1876, 1877, 1878, 1879, 1880, 1881, 1882, 1883, 1884, 1885, 1886, 1887, 1888, 1889, 1890, 1891, 1892, 1893, 1894, 1895, 1896, 1897, 1898, 1899, 1900, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 1917, 1918, 1919, 1920, 1921, 1922, 1923, 1924, 1925, 1926, 1927, 1928, 1929, 1930, 1931, 1932, 1933, 1934, 1935, 1936, 1937, 1938, 1939, 1940, 1941, 1942, 1943, 1944, 1945, 1946, 1947, 1948, 1949, 1950, 1951, 1952, 1953, 1954, 1955, 1956, 1957, 1958, 1959, 1960, 1961, 1962, 1963, 1964, 1965, 1966, 1967, 1968, 1969, 1970, 1971, 1972, 1973, 1974, 1975, 1976, 1977, 1978, 1979, 1980, 1981, 1982, 1983, 1984, 1985, 1986, 1987, 1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000}, arg2: true, arg3: 800, arg4: 50, arg5: 50f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Stateboss_leftTurn_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn_b : TriggerState {
            internal Stateboss_leftTurn_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 11, enable: true, path: @"BG\Common\Sound\Eff_Object_WaterJump_Splash_01.xml");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2003");
                context.CreateMonster(arg1: new[] {305}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Stateboss_leftTurn_b_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn_b_01 : TriggerState {
            internal Stateboss_leftTurn_b_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 305, arg3: "$02000389_BF__MAIN__11$", arg4: 3, arg5: 0);
                context.SetBreakable(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 1225, 1226, 1227, 1228, 1229, 1230, 1231, 1232, 1233, 1234, 1235, 1236, 1237, 1238, 1239, 1240, 1241, 1242, 1243, 1244, 1245, 1246, 1247, 1248, 1249, 1250, 1251, 1252, 1253, 1254, 1255, 1256, 1257, 1258, 1259, 1260, 1261, 1262, 1263, 1264, 1265, 1266, 1267, 1268, 1269, 1270, 1271, 1272, 1273, 1274, 1275, 1276, 1277, 1278, 1279, 1280, 1281, 1282, 1283, 1284, 1285, 1286, 1287, 1288, 1289, 1290, 1291, 1292, 1293, 1294, 1295, 1296, 1297, 1298, 1299, 1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348, 1349, 1350, 1351, 1352, 1353, 1354, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1370, 1371, 1372, 1373, 1374, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1382, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1460, 1461, 1462, 1463, 1464, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1489, 1490, 1491, 1492, 1493, 1494, 1495, 1496, 1497, 1498, 1499, 1500, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1509, 1510, 1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518, 1519, 1520, 1521, 1522, 1523, 1524, 1525, 1526, 1527, 1528, 1529, 1530, 1531, 1532, 1533, 1534, 1535, 1536, 1537, 1538, 1539, 1540, 1541, 1542, 1543, 1544, 1545, 1546, 1547, 1548, 1549, 1550, 1551, 1552, 1553, 1554, 1555, 1556, 1557, 1558, 1559, 1560, 1561, 1562, 1563, 1564, 1565, 1566, 1567, 1568, 1569, 1570, 1571, 1572, 1573, 1574, 1575, 1576, 1577, 1578, 1579, 1580, 1581, 1582, 1583, 1584, 1585, 1586, 1587, 1588, 1589, 1590, 1591, 1592, 1593, 1594, 1595, 1596, 1597, 1598, 1599, 1600, 1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608, 1609, 1610, 1611, 1612, 1613, 1614, 1615, 1616, 1617, 1618, 1619, 1620, 1621, 1622, 1623, 1624, 1625, 1626, 1627, 1628, 1629, 1630, 1631, 1632, 1633, 1634, 1635, 1636, 1637, 1638, 1639, 1640, 1641, 1642, 1643, 1644, 1645, 1646, 1647, 1648, 1649, 1650, 1651, 1652, 1653, 1654, 1655, 1656, 1657, 1658, 1659, 1660, 1661, 1662, 1662, 1663, 1664, 1665, 1666, 1667, 1668, 1669, 1670, 1671, 1672, 1673, 1674, 1675, 1676, 1677, 1678, 1679, 1680, 1681, 1682, 1683, 1684, 1685, 1686, 1687, 1688, 1689, 1690, 1691, 1692, 1693, 1694, 1695, 1696, 1697, 1698, 1699, 1700, 1701, 1702, 1703, 1704, 1705, 1706, 1707, 1708, 1709, 1710, 1711, 1712, 1713, 1714, 1715, 1716, 1717, 1718, 1719, 1720, 1721, 1722, 1723, 1724, 1725, 1726, 1727, 1728, 1729, 1730, 1731, 1732, 1733, 1734, 1735, 1736, 1737, 1738, 1739, 1740, 1741, 1742, 1743, 1744, 1745, 1746, 1747, 1748, 1749, 1750, 1751, 1752, 1753, 1754, 1755, 1756, 1757, 1758, 1759, 1760, 1761, 1762, 1763, 1764, 1765, 1766, 1767, 1768, 1769, 1770, 1771, 1772, 1773, 1774, 1775, 1776, 1777, 1778, 1779, 1780, 1781, 1782, 1783, 1784, 1785, 1786, 1787, 1788, 1789, 1790, 1791, 1792, 1793, 1794, 1795, 1796, 1797, 1798, 1799, 1800, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809, 1810, 1811, 1812, 1813, 1814, 1815}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 305, arg2: "Attack_01_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Stateboss_leftTurn_b_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn_b_02 : TriggerState {
            internal Stateboss_leftTurn_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetSkill(arg1: new[] {30005, 30010, 30011}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Stateboss_leftTurn_b_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn_b_03 : TriggerState {
            internal Stateboss_leftTurn_b_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 305, arg2: "MS2PatrolData_2004");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Stateboss_leftTurn_b_04_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn_b_04_ready : TriggerState {
            internal Stateboss_leftTurn_b_04_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new Stateboss_leftTurn_b_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateboss_leftTurn_b_04 : TriggerState {
            internal Stateboss_leftTurn_b_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {305, 303, 101, 102});
                context.CreateMonster(arg1: new[] {103, 104}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnding_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_01 : TriggerState {
            internal StateEnding_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "Ending_03_ready");
                context.SetMesh(arg1: new[] {1990, 1991, 1992, 1993}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 3101, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 3102, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 3103, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 3104, arg2: true, arg3: "Idle_A");
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000389_BF__MAIN__12$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$02000389_BF__MAIN__13$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnding_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class StateEnding_02 : TriggerState {
            internal StateEnding_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_03_ready : TriggerState {
            internal StateEnding_03_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetLocalCamera(cameraId: 8100, enable: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8100, enable: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new[] {7001, 7002, 7003, 7004, 7005, 7011, 7012, 7013}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000389_BF__MAIN__14$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$02000389_BF__MAIN__15$", arg4: 2, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000389_BF__MAIN__16$", arg4: 2, arg5: 7);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$02000389_BF__MAIN__17$", arg4: 2, arg5: 9);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}